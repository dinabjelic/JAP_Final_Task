using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Core.Helpers;
using RecipesApp.Core.Requests;
using RecipesApp.Database;
using RecipesApp.Database.Entities;
using RecipesApp.Interfaces;
using RecipesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Services
{
    public class Categories : ICategoryService
    {
        private readonly RecipesDbContext _context;
        private readonly IMapper _mapper;

        public Categories(RecipesDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedList<RecipeCategory>> GetCategoryAsync(PaginationParams paginationParams)
        {
            var query = _context.RecipesCategories.AsNoTracking();
            var pagination= await PagedList<RecipeCategory>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return pagination;
        }

        public async Task<List<AddRecipeRequest>> CategoriesListAsync()
        {
            var categoryList =await _context.RecipesCategories
                .Select(x => new AddRecipeRequest
                {
                    CategoryId = x.Id,
                    CategoryName = x.Name
                }).ToListAsync();

            return categoryList;
        }

        public async Task NewRecipeCategoryAsync(int recipeId, int categoryId)
        {
            var recipesCategory = new RecipeCategoryRecipe();

            recipesCategory.RecipesCategoryId = categoryId;
            recipesCategory.RecipesId = recipeId;
                
            await _context.RecipesCategoryRecipes.AddAsync(recipesCategory);
            await _context.SaveChangesAsync();
        }

        public async Task AddCategoryAsync(AddCategoryRequest addCategoryRequest)
        {
            var dbRecipeCategory = _mapper.Map<RecipeCategory>(addCategoryRequest);

            await _context.RecipesCategories.AddAsync(dbRecipeCategory);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(UpdateCategoryRequest updateCategoryRequest)
        {
           
               var recipesCategory = _context.RecipesCategories.Find(updateCategoryRequest.Id);
               _mapper.Map(updateCategoryRequest, recipesCategory);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int categorId)
        {
            RecipeCategory recipesCategory = _context.RecipesCategories.Find(categorId);

            foreach(var x in _context.RecipesCategoryRecipes.Where(a=>a.RecipesCategoryId == categorId))
            {
                _context.RecipesCategoryRecipes.Remove(x);
            }

            _context.RecipesCategories.Remove(recipesCategory);
            await _context.SaveChangesAsync();
        }

        public async Task<List<RecipeCategory>> GetCurrentDataAsync(int categoryId)
        {
            var currentData = await _context.RecipesCategories.Where(x => x.Id == categoryId).ToListAsync();

            return currentData;
        }
    }
}
