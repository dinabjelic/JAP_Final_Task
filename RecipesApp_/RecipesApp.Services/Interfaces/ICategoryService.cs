using RecipesApp.Core.Helpers;
using RecipesApp.Core.Requests;
using RecipesApp.Database.Entities;
using RecipesApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesApp.Interfaces
{
    public interface ICategoryService
    {
        /// <summary>
        /// Returns recipe categories. This method also includes pagination
        /// </summary>
        /// <param name="paginationParams"></param>
        /// <returns></returns>
        Task<PagedList<RecipeCategory>> GetCategoryAsync(PaginationParams paginationParams);
        /// <summary>
        /// Returns all categories which are available
        /// </summary>
        /// <returns></returns>
        Task<List<AddRecipeRequest>> CategoriesListAsync();
        /// <summary>
        /// Saves recipe and ingredients for the recipe in intermediate table
        /// </summary>
        /// <param name="RecipeId"></param>
        /// <param name="CategoryId"></param>
        /// <returns></returns>
        Task NewRecipeCategoryAsync(int recipeId, int categoryId);
        /// <summary>
        /// Creates new category 
        /// </summary>
        /// <param name="addCategoryRequest"></param>
        /// <returns></returns>
        Task AddCategoryAsync(AddCategoryRequest addCategoryRequest);
        /// <summary>
        /// Editing existing category
        /// </summary>
        /// <param name="updateCategoryRequest"></param>
        /// <returns></returns>
        Task UpdateCategoryAsync(UpdateCategoryRequest updateCategoryRequest);
        /// <summary>
        /// Deletes choosen category 
        /// </summary>
        /// <param name="categorId"></param>
        /// <returns></returns>
        Task DeleteCategoryAsync(int categorId);
        /// <summary>
        /// Gets current category data requested by id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        Task<RecipeCategory> GetByIdAsync(int categoryId);
    }
}
