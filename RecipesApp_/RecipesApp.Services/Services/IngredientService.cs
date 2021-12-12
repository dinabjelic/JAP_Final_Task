using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dapper;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Core.Dtos;
using RecipesApp.Core.Helpers;
using RecipesApp.Core.Models;
using RecipesApp.Core.Models.Procedures;
using RecipesApp.Core.Requests;
using RecipesApp.Database;
using RecipesApp.Database.Entities;
using RecipesApp.Interfaces;
using RecipesApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Services
{
    public class IngredientService:IIngredientService
    {
        private readonly RecipesDbContext _context;
        private readonly IMapper _mapper;


        public IngredientService(RecipesDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GetIngredientResponse>> IngredientsListAsync()
        {
            var ingredientList = await _context.Ingredients
                .Select(x => new GetIngredientResponse
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();

            return ingredientList;
        }
        public Task<IEnumerable<GetIngredientModel>> GetIngredientsAsync(int MeasureType, int MinQuantity, int MaxQuantity)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@MeasureType", MeasureType);
            parameters.Add("@MinQuantity", MinQuantity);
            parameters.Add("@MaxQuantity", MaxQuantity);

            return _context.Database.GetDbConnection().QueryAsync<GetIngredientModel>("GetIngredients",parameters,commandType: CommandType.StoredProcedure);

        }
        public async Task NewIngredientAsync(List<IngredientRequest> list)
        {
            foreach (var item in list)
            {
                   IngredientRecipe ingredientsRecipes = new IngredientRecipe();

                    ingredientsRecipes.RecipesId = item.RecipeId;
                    ingredientsRecipes.IngredientsId = item.IngredientId;
                    ingredientsRecipes.Quantity = item.Quantity;
                    ingredientsRecipes.Measure = item.Measure;
                    await _context.IngredientsRecepies.AddAsync(ingredientsRecipes);
            }
            await _context.SaveChangesAsync();
        }
        public async Task AddIngredientAsync(AddIngredientRequest addIngredientRequest)
        {
            var dbIngredient = _mapper.Map<Ingredient>(addIngredientRequest);

            await _context.Ingredients.AddAsync(dbIngredient);
            await _context.SaveChangesAsync();
        }

        public async Task<PagedList<GetIngredientsResponse>> GetAllIngredientsAsync(PaginationParams paginationParams, IngredientSearch ingredientSearch)
        {
            var ingredients = _context.Ingredients.AsQueryable();

            ingredients = paginationParams.OrderBy switch
            {
                "name" => ingredients.OrderByDescending(u => u.Name),
                "quantity"=> ingredients.OrderByDescending(u=>u.Quantity),
                _ => ingredients.OrderBy(u => u.Price)
            };

            if (!string.IsNullOrEmpty(ingredientSearch.IngredientName))
            {
                ingredients = ingredients.Where(x => x.Name.Contains(ingredientSearch.IngredientName));
            }
            if (ingredientSearch.Quantity.HasValue)
            {
                ingredients = ingredients.Where(x => x.Quantity == ingredientSearch.Quantity);
            }
            if (ingredientSearch.Measure.HasValue)
            {
                ingredients = ingredients.Where(x => x.Measure == ingredientSearch.Measure);
            }

            return await PagedList<GetIngredientsResponse>.CreateAsync(ingredients.ProjectTo<GetIngredientsResponse>
                (_mapper.ConfigurationProvider).AsNoTracking(),paginationParams.PageNumber, paginationParams.PageSize);
        }

        public async Task UpdateIngredientAsync(UpdateIngredientRequest updateIngredientRequest)
        {
            var ingredient = _context.Ingredients.Find(updateIngredientRequest.Id);
            _mapper.Map(updateIngredientRequest,ingredient);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteIngredientAsync(int ingredientId)
        {
            var ingredient = _context.Ingredients.Find(ingredientId);

            foreach (var x in _context.IngredientsRecepies.Where(a => a.IngredientsId == ingredientId))
            {
                _context.IngredientsRecepies.Remove(x);
            }

            _context.Ingredients.Remove(ingredient);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Ingredient>> GetCurrentDataAsync(int ingredientId)
        {
            var currentData = await _context.Ingredients.Where(x => x.Id == ingredientId).ToListAsync();

            return currentData;
        }
    }
}
