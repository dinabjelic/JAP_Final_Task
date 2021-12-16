using RecipesApp.Core.Models;
using RecipesApp.Core.Requests;
using RecipesApp.Database.Entities;
using RecipesApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesApp.Interfaces
{
    public interface IRecipeService
    {
        /// <summary>
        /// Returns all recipes that are part of choosen category, like breakfast category and all recipes included in breakfast category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<GetCategoryRecipeResponse>> GetRecipesForCategoryAsync(int id, string search);
        /// <summary>
        /// Returns recipe details for choosen recipe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<GetRecipeDetailsResponse> GetRecipesDetailsAsync(int id);
        /// <summary>
        /// Method that saves recipe in database
        /// </summary>
        /// <param name="recipesModel"></param>
        /// <returns></returns>
        Task AddRecipeAsync(AddRecipeRequest recipesModel);
        /// <summary>
        /// Editing existing recipe
        /// </summary>
        /// <param name="updateRecipeRequest"></param>
        /// <returns></returns>
        Task UpdateRecipeAsync(UpdateRecipeRequest updateRecipeRequest);
        /// <summary>
        /// Deletes choosen recipe
        /// </summary>
        /// <param name="recipeId"></param>
        /// <returns></returns>
        Task DeleteRecipeAsync(int recipeId);
        /// <summary>
        /// Edits recipe details
        /// </summary>
        /// <param name="updateRecipeDetailsRequest"></param>
        /// <returns></returns>
        Task UpdateRecipesDetailsAsync(UpdateRecipeDetailsRequest updateRecipeDetailsRequest);
        /// <summary>
        ///  Gets current recipe data requested by id
        /// </summary>
        /// <param name="recipeId"></param>
        /// <returns></returns>
        Task<Recipe> GetByIdAsync(int recipeId);
    }
}
