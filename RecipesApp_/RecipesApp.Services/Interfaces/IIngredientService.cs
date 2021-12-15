using RecipesApp.Core.Dtos;
using RecipesApp.Core.Helpers;
using RecipesApp.Core.Models;
using RecipesApp.Core.Models.Procedures;
using RecipesApp.Core.Requests;
using RecipesApp.Database.Entities;
using RecipesApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesApp.Interfaces
{
    public interface IIngredientService
    {
        /// <summary>
        /// Returns all ingredients which are available 
        /// </summary>
        /// <returns></returns>
        Task<List<GetIngredientResponse>> IngredientsListAsync();
        /// <summary>
        /// Procedure which returns ingredients based on measure type, min and max quantity
        /// </summary>
        /// <param name="MeasureType"></param>
        /// <param name="MinQuantity"></param>
        /// <param name="MaxQuantity"></param>
        /// <returns></returns>
        Task<IEnumerable<GetIngredientModel>> GetIngredientsAsync(int MeasureType, int MinQuantity, int MaxQuantity);
        /// <summary>
        /// Saves all ingredients for the recipe that is last added in database
        /// </summary>
        /// <param name="recipesModel"></param>
        /// <returns></returns>
        Task NewIngredientAsync(List<IngredientRequest> recipesModel);
        /// <summary>
        /// Creates new ingredient
        /// </summary>
        /// <param name="addIngredientRequest"></param>
        /// <returns></returns>
        Task AddIngredientAsync(AddIngredientRequest addIngredientRequest);
        /// <summary>
        /// Returns all recipes from database
        /// </summary>
        /// <param name="paginationParams"></param>
        /// <param name="ingredientSearch"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        Task<PagedList<GetIngredientsResponse>> GetAllIngredientsAsync(IngredientSearch ingredientSearch);
        /// <summary>
        /// Editing existing ingredient
        /// </summary>
        /// <param name="updateIngredientRequest"></param>
        /// <returns></returns>
        Task UpdateIngredientAsync(UpdateIngredientRequest updateIngredientRequest);
        /// <summary>
        /// Deletes choosen ingredient
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <returns></returns>
        Task DeleteIngredientAsync(int ingredientId);
        /// <summary>
        ///  Gets current ingredient data search by id
        /// </summary>
        /// <param name="ingredientId"></param>
        /// <returns></returns>
        Task<List<Ingredient>> GetCurrentDataAsync(int ingredientId);

    }
}
