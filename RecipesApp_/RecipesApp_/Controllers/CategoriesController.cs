using DatingApp.API.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Core.Extensions;
using RecipesApp.Core.Helpers;
using RecipesApp.Core.Requests;
using RecipesApp.Interfaces;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Authorize]
    public class CategoriesController : BaseApiController
    {
        private readonly ICategoryService _categories;
        public CategoriesController(ICategoryService recipesCategories)
        {
            _categories = recipesCategories;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetCategories([FromQuery]PaginationParams paginationParams)
        {
            var categories = await _categories.GetCategoryAsync(paginationParams);

            Response.AddPaginationHeader(categories.CurrentPage, categories.PageSize, categories.TotalCount, categories.TotalPages);
            return Ok(categories);
        }

        [HttpGet("categories-list")]
        public async Task<IActionResult> GetCategoriesList()
        {
            return Ok(await _categories.CategoriesListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryRequest addCategoryRequest)
        {
             await _categories.AddCategoryAsync(addCategoryRequest);
             return Ok("You succeeded");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            await _categories.UpdateCategoryAsync(updateCategoryRequest);
            return Ok("You succeeded");
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
             await _categories.DeleteCategoryAsync(categoryId);
             return Ok("You succeeded");
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetCurrentCategoryData(int categoryId)
        {
           return Ok(await _categories.GetByIdAsync(categoryId));
        }
    }
}
