using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using RecipesApp.Common.Enums;
using RecipesApp.Core.Helpers;
using RecipesApp.Core.Models;
using RecipesApp.Core.Requests;
using RecipesApp.Database;
using RecipesApp.Database.Entities;
using RecipesApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Services.Tests
{
    [TestFixture]
    public class CategoryServiceTests
    {
        private DbContextOptions<RecipesDbContext> _options;
        private RecipesDbContext _context;
        private Categories _categoryService;

        public CategoryServiceTests()
        {
            _options = new DbContextOptionsBuilder<RecipesDbContext>()
               .UseInMemoryDatabase(databaseName: "CategoryDB").Options;
            _context = new RecipesDbContext(_options);
            var mapperConfiguration = new MapperConfiguration(x => { x.CreateMap<RecipeCategory, AddCategoryRequest>().ReverseMap(); });
            _categoryService = new Categories(_context, mapperConfiguration.CreateMapper());
        }

        //paging test
        [Test]
        [TestCase(10)]
        public async Task GetCategoryAsync_PageSize__ShowCategories(int pageSize)
        {
            var paginationRequest = new PaginationParams { PageSize = pageSize };

            var sendRequest = await _categoryService.GetCategoryAsync(paginationRequest);

            Assert.That(sendRequest.PageSize, Is.EqualTo(pageSize));
        }

        [Test]
        [TestCase(1, 20)]
        public async Task GetCategoryAsync_PageSize_PageNumber_ShowCategories(int pageNumber, int pageSize)
        {
            var paginationRequest = new PaginationParams { PageSize = pageSize, PageNumber = pageNumber };

            var sendRequest = await _categoryService.GetCategoryAsync(paginationRequest);

            Assert.That(sendRequest.PageSize, Is.EqualTo(pageSize));
            Assert.That(sendRequest.CurrentPage, Is.EqualTo(pageNumber));
        }

        [Test]
        [TestCase(2, 30)]
        public async Task GetCategoryAsync_PageSize2_PageNumber2_ShowCategories(int pageNumber, int pageSize)
        {
            var paginationRequest = new PaginationParams { PageSize = pageSize, PageNumber = pageNumber };

            var sendRequest = await _categoryService.GetCategoryAsync(paginationRequest);

            Assert.That(sendRequest.PageSize, Is.EqualTo(pageSize));
            Assert.That(sendRequest.CurrentPage, Is.EqualTo(pageNumber));
        }

        //categoryTest
        [Test]
        public async Task AddRecipeD_RecipeOneOneIngredient_RecipeAdded()
        {
            var recipeOne = new AddRecipeRequest
            {
                
                Name = "RecipeOne",
                Price = 10,
                Description = "Description",
                UserID = 1,
                CategoryId = 1,
                IngredientsList = new List<GetIngredientResponse>
                {
                    new GetIngredientResponse
                    {
                        Id=1,
                        Name="Ingredient1",
                        Price=5,
                        Quantity=500,
                        Measure=UnitMeasureType.gr,
                    }
                }
            };

            await _categoryService.NewRecipeCategory(1,recipeOne.CategoryId);

            var recipeFromDb = await _context.RecipesCategoryRecipes.Where(x => x.RecipesId == 1 && x.RecipesCategoryId==1).ToListAsync();

            Assert.True(recipeFromDb.Any());
        }
    }
}
