using DatingApp.API.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecipesApp.Core.Requests;
using RecipesApp.Interfaces;
using RecipesApp.Models;
using RecipesApp.Services.Interfaces;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Authorize]
    public class RecipesController : BaseApiController
    {

        private readonly IRecipeService _categoryRecipes;
        private readonly IGetRecipeService _getRecipeService;
        

        public RecipesController(IRecipeService categoryRecipes, IGetRecipeService getRecipeService)
        {
            _categoryRecipes = categoryRecipes;
            _getRecipeService = getRecipeService;
        }

        [AllowAnonymous]
        [HttpGet("{recipeCategoryId}")]
        public async Task<IActionResult> GetRecipesForCategory(int recipeCategoryId,string searchTerm)
        {
            var recipesCategory = await _categoryRecipes.GetRecipesForCategoryAsync(recipeCategoryId,searchTerm);

            if (recipesCategory == null)
            {
                return NotFound();
            }

            return Ok(recipesCategory);
        }

        [AllowAnonymous]
        [HttpGet("recipe-details/{recipeId}")]
        public async Task<IActionResult> GetRecipeDetails(int recipeId)
        {

            var recipeDetails = await _categoryRecipes.GetRecipesDetailsAsync(recipeId);

            if (recipeDetails == null)
            {
                return NotFound();
            }

            return Ok(recipeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(AddRecipeRequest recipesModel)
        {
            if (recipesModel.UserID != 0)
            {
                await _categoryRecipes.AddRecipeAsync(recipesModel);
                return Ok("You successed");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetRecipes()
        {
            return Ok(await _getRecipeService.GetRecipesAsync());
        }

        [HttpGet("all-recipes")]
        public async Task<IActionResult> GetAllRecipes()
        {
            return Ok(await _getRecipeService.GetAllRecipesAsync());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRecipe(UpdateRecipeRequest updateRecipeRequest)
        {
            if(updateRecipeRequest.Id != 0)
            {
                await _categoryRecipes.UpdateRecipeAsync(updateRecipeRequest);
                return Ok("You successed");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{recipeId}")]
        public async Task<IActionResult> DeleteRecipe(int recipeId)
        {
            if (recipeId != 0)
            {
                await _categoryRecipes.DeleteRecipeAsync(recipeId);
                return Ok("You successed");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut("update-recipe-details")]
        public async Task<IActionResult> UpdateRecipesDetailsAsync(UpdateRecipeDetailsRequest updateRecipeDetailsRequest)
        {
            if (updateRecipeDetailsRequest.IngredientsId != 0 && updateRecipeDetailsRequest.RecipesId != 0)
            {
                await _categoryRecipes.UpdateRecipesDetailsAsync(updateRecipeDetailsRequest);
                return Ok("You successed");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("current-data/{recipeId}")]
        public async Task<IActionResult> GetCurrentRecipeData(int recipeId)
        {
            return Ok(await _categoryRecipes.GetCurrentDataAsync(recipeId));
        }
    }
}
