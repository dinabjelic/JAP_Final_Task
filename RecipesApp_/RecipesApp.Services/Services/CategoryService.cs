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
            if (addCategoryRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var dbRecipeCategory = _mapper.Map<RecipeCategory>(addCategoryRequest);
            await _context.RecipesCategories.AddAsync(dbRecipeCategory);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(UpdateCategoryRequest updateCategoryRequest)
        {
            if (updateCategoryRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var recipesCategory = await _context.RecipesCategories.FirstOrDefaultAsync(x=>x.Id==updateCategoryRequest.Id);

            if (recipesCategory == null)
            {
                throw new ArgumentException("Invalid categoryId");
            }

            _mapper.Map(updateCategoryRequest, recipesCategory);
            _context.RecipesCategories.Update(recipesCategory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int categoryId)
        {
            var recipesCategory =await _context.RecipesCategories.FirstOrDefaultAsync(x=>x.Id==categoryId);

            if (recipesCategory == null)
            {
                throw new ArgumentException("Invalid categoryId");
            }

            _context.RecipesCategories.Remove(recipesCategory);
            await _context.SaveChangesAsync();
        }

        public async Task<RecipeCategory> GetByIdAsync(int categoryId)
        {
            var currentData = await _context.RecipesCategories.FirstOrDefaultAsync(x => x.Id == categoryId);

            if (currentData == null)
            {
                throw new ArgumentException("Invalid categoryId");
            }

            return currentData;
        }
    }
}
