using DatingApp.API.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Core.Dtos;
using RecipesApp.Core.Extensions;
using RecipesApp.Core.Helpers;
using RecipesApp.Core.Requests;
using RecipesApp.Interfaces;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Authorize]
    public class IngredientsController : BaseApiController
    {
        private readonly IIngredientService _ingredientService;
        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetIngredientList()
        {
            return Ok(await _ingredientService.IngredientsListAsync());
        }

        [HttpGet("ingredients-list")]
        public async Task<IActionResult> GetIngredients(int MeasureType, int MinQuantity, int MaxQuantity)
        {
            return Ok(await _ingredientService.GetIngredientsAsync(MeasureType, MinQuantity, MaxQuantity));
        }
        [HttpPost]
        public async Task<IActionResult> AddIngredient(AddIngredientRequest addIngredientRequest)
        {
              await _ingredientService.AddIngredientAsync(addIngredientRequest);
              return Ok("You succeeded");
        }

        [HttpGet("all-ingredients")]
        public async Task<IActionResult> GetAllIngredients([FromQuery]IngredientSearch ingredientSearch)
        {
            var ingredients = await _ingredientService.GetAllIngredientsAsync(ingredientSearch);

            Response.AddPaginationHeader(ingredients.CurrentPage, ingredients.PageSize, ingredients.TotalCount, ingredients.TotalPages);

            return Ok(ingredients);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateIngredient(UpdateIngredientRequest updateIngredientRequest)
        {
             await _ingredientService.UpdateIngredientAsync(updateIngredientRequest);
             return Ok("You successed");
        }

        [HttpDelete("{ingredientId}")]
        public async Task<IActionResult> DeleteIngredient(int ingredientId)
        {
              await _ingredientService.DeleteIngredientAsync(ingredientId);
              return Ok("You successed");
        }

        [HttpGet("{ingredientId}")]
        public async Task<IActionResult> GetCurrentIngredientData(int ingredientId)
        {
            return Ok(await _ingredientService.GetByIdAsync(ingredientId));
        }
    }
}
