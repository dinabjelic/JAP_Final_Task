using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Core.Requests;
using RecipesApp.Database;
using RecipesApp.Database.Entities;
using RecipesApp.Interfaces;
using RecipesApp.Models;
using RecipesApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly RecipesDbContext _context;
        private readonly IIngredientRecipeCostService _ingredientRecipeCostService;
        private readonly IIngredientService _ingredientService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public RecipeService(RecipesDbContext context, IMapper mapper,
            IIngredientRecipeCostService ingredientRecipeCostService,
            IIngredientService ingredientService,
            ICategoryService categoryService)
        {
            _context = context;
            _ingredientService = ingredientService;
            _categoryService = categoryService;
            _ingredientRecipeCostService = ingredientRecipeCostService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCategoryRecipeResponse>> GetRecipesForCategoryAsync(int recipeCategoryId,string searchTerm)
        {

            var list = await _context.RecipesCategoryRecipes
                .Include(d => d.Recipes)
                .Include(f => f.RecipesCategory)
                .Where(d => d.RecipesCategoryId == recipeCategoryId)
                .OrderBy(d => d.Recipes.Price)
                .Select(
                    d => new GetCategoryRecipeResponse
                    {
                        RecipesCategoryId = d.RecipesCategoryId,
                        RecipeId = d.RecipesId,
                        CategoryName = d.RecipesCategory.Name,
                        Name = d.Recipes.Name,
                        Price = Math.Round(d.Recipes.Price, 3)
                    })
               .ToListAsync();


            if (!string.IsNullOrEmpty(searchTerm))
            {
                list = list.Where(x => x.Name.ToLower().Contains(searchTerm)).ToList();
            }

            return list;
        }

        public async Task<GetRecipeDetailsResponse> GetRecipesDetailsAsync(int recipeId)
        {
            var recipe = await _context.Recipes
                 .Include(c => c.IngredientRecipes)
                 .ThenInclude(c => c.Ingredients)
                .Where(x => x.Id == recipeId)
                .OrderBy(x => x.Price)
                .FirstOrDefaultAsync();

           var recipeDetails= _mapper.Map<GetRecipeDetailsResponse>(recipe);

            _ingredientRecipeCostService.IngredientRecipeCost(recipeDetails);

            return recipeDetails;
        }

        public async Task UpdateRecipesDetailsAsync(UpdateRecipeDetailsRequest updateRecipeDetailsRequest)
        {
            var ingredientRecipeDetails =
                _context.IngredientsRecepies.FirstOrDefault(x => x.RecipesId == updateRecipeDetailsRequest.RecipesId && x.IngredientsId == updateRecipeDetailsRequest.IngredientsId);
            
            _mapper.Map(updateRecipeDetailsRequest, ingredientRecipeDetails);

            await _context.SaveChangesAsync();
        }


        public async Task AddRecipeAsync(AddRecipeRequest recipesModel)
        {
            if (recipesModel.IngredientsList.Count == 0)
            {
                throw new ArgumentException("Ingredient list is empty");
            }

            if (recipesModel.CategoryId == 0)
            {
                throw new ArgumentException("Category is not added");
            }

            if (recipesModel.IngredientsList.GroupBy(x => x.Id).Any(x => x.Count() > 1))
            {
                throw new ArgumentException("Can not add same ingredient");
            }

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var dbRecipe = _mapper.Map<Recipe>(recipesModel);
                await _context.Recipes.AddAsync(dbRecipe);
                await _context.SaveChangesAsync();

                //taking recipeId from added recipe
                var recipeIngredients = recipesModel.IngredientsList.Select(x => new IngredientRequest
                {
                    RecipeId = dbRecipe.Id,
                    IngredientId = x.Id,
                    Measure = x.Measure,
                    Quantity = x.Quantity,
                }).ToList();


                await _ingredientService.NewIngredientAsync(recipeIngredients);
                await _categoryService.NewRecipeCategoryAsync(dbRecipe.Id, recipesModel.CategoryId);

                await transaction.CommitAsync();
            }
            catch(Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task UpdateRecipeAsync(UpdateRecipeRequest updateRecipeRequest)
        {
            var recipe =await _context.Recipes.FirstOrDefaultAsync(x=>x.Id==updateRecipeRequest.Id);
            if (recipe == null)
            {
                throw new ArgumentException("Invalid recipeId");
            }
            _mapper.Map(updateRecipeRequest, recipe);

            await _context.SaveChangesAsync();
        }
        public async Task DeleteRecipeAsync(int recipeId)
        {
            var recipe =await _context.Recipes.FirstOrDefaultAsync(x=>x.Id==recipeId);
            if (recipe == null)
            {
                throw new ArgumentException("Invalid recipeId");
            }
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Recipe>> GetCurrentDataAsync(int recipeId)
        {
            var currentData = await _context.Recipes.Where(x => x.Id == recipeId).ToListAsync();

            return currentData;
        }
    }
}
