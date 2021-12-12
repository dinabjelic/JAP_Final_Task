using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using NUnit.Framework;
using RecipesApp.Common.Enums;
using RecipesApp.Core.Models;
using RecipesApp.Database;
using RecipesApp.Database.Entities;
using RecipesApp.Interfaces;
using RecipesApp.Models;
using RecipesApp.Services.Interfaces;
using RecipesApp.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Services.Tests
{
    [TestFixture]
    public class RecipeServiceTests
    {

        private DbContextOptions<RecipesDbContext> _options;
        private RecipeService _recipeService;
        private RecipesDbContext _context;
        private Mock<IIngredientRecipeCostService> ingredientRecipeCostService;
        private Mock<IIngredientService> ingredientService;
        private Mock<ICategoryService> categoryService;


        public RecipeServiceTests()
        {
            _options = new DbContextOptionsBuilder<RecipesDbContext>()
                   .UseInMemoryDatabase(databaseName: "RecipesDB")
                   .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning)).Options;
            _context = new RecipesDbContext(_options);
            ingredientRecipeCostService =new Mock<IIngredientRecipeCostService>();
            ingredientService = new Mock<IIngredientService>();
            categoryService = new Mock<ICategoryService>();
            var mapperConfiguration = new MapperConfiguration(x => { x.CreateMap<Recipe, AddRecipeRequest>().ReverseMap(); });

            _recipeService = new RecipeService(_context, mapperConfiguration.CreateMapper(), 
                ingredientRecipeCostService.Object, ingredientService.Object,
                categoryService.Object);
        }

        //creating recipe
        [Test]
        public async Task AddRecipe_RecipeOneOneIngredient_RecipeAdded()
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

            await _recipeService.AddRecipe(recipeOne);

            var recipeFromDb = _context.Recipes.FirstOrDefault(x => x.Name == recipeOne.Name);

            Assert.AreEqual(recipeOne.Name, recipeFromDb.Name);
            Assert.AreEqual(recipeOne.Price, recipeFromDb.Price);
            Assert.AreEqual(recipeOne.Description, recipeFromDb.Description);
            Assert.AreEqual(recipeOne.UserID, recipeFromDb.UserID);

        }

        [Test]
        public async Task AddRecipe_IngredientListEmpty_ThrowException()
        {
            var recipeTwo = new AddRecipeRequest
            {
                Name = "NameTwoRecipeTest",
                Price = 10,
                Description = "Description",
                UserID = 1,
                CategoryId = 1,
                IngredientsList = new List<GetIngredientResponse>
                {
                }
            };

            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.AddRecipe(recipeTwo));
        }

        [Test]
        public async Task AddRecipe_CategoryId0_ThrowException()
        {
            var recipeThree = new AddRecipeRequest
            {
                Name = "RecipeThree",
                Price = 10,
                Description = "Description",
                UserID = 1,
                CategoryId = 0,
                IngredientsList = new List<GetIngredientResponse>
                {
                    new GetIngredientResponse
                    {
                        Id=1,
                        Name="Ingredient1",
                        Price=5,
                        Quantity=500,
                        Measure=UnitMeasureType.gr
                    }
                }
            };

            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.AddRecipe(recipeThree));
        }



        //cant add two ingredients for one recipe
        [Test]
        public async Task AddRecipe_SendingTwoIngredients_FailedToAddTwoSameIngredients()
        {
            var recipeOne = new AddRecipeRequest
            {
                Name = "RecipeOneTest",
                Description = "Description",
                UserID = 1,
                CategoryId = 1,
                IngredientsList = new List<GetIngredientResponse>
                {
                    new GetIngredientResponse
                    {
                       Id=12,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                    new GetIngredientResponse
                    {
                       Id=12,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    }
                }
            };

            try
            {
                await _recipeService.AddRecipe(recipeOne);
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail();
        }

        [Test]
        public async Task AddRecipe_SendingThreeIngredients_FailedToAddTwoSameIngredients()
        {
            var recipeTwo = new AddRecipeRequest
            {
                Name = "RecipeNameTwo",
                Description = "Description",
                UserID = 1,
                CategoryId = 1,
                IngredientsList = new List<GetIngredientResponse>
                {
                    new GetIngredientResponse
                    {
                       Id=13,
                       Name="Ingredient13",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                     new GetIngredientResponse
                    {
                       Id=14,
                       Name="Ingredient14",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                       new GetIngredientResponse
                    {
                       Id=13,
                       Name="Ingredient13",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    }

                }
            };
            try
            {
                await _recipeService.AddRecipe(recipeTwo);
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail();
        }

        [Test]
        public async Task AddRecipe_SendingManyIngredients_FailedToAddTwoSameIngredients()
        {
            var recipeTwo = new AddRecipeRequest
            {
                Name = "RecipeTwoTest",
                Description = "Description",
                UserID = 1,
                CategoryId = 1,
                IngredientsList = new List<GetIngredientResponse>
                {
                    new GetIngredientResponse
                    {
                       Id=13,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                    new GetIngredientResponse
                    {
                       Id=13,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                     new GetIngredientResponse
                    {
                       Id=14,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                      new GetIngredientResponse
                    {
                       Id=14,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                       new GetIngredientResponse
                    {
                       Id=13,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    },
                          new GetIngredientResponse
                    {
                       Id=15,
                       Name="Ingredient1",
                       Quantity= 5,
                       Measure=UnitMeasureType.kg
                    }

                }
            };

            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.AddRecipe(recipeTwo));

        }

        [Test]
        public void AddRecipe_Sending0Ingredients_ReturnsFalse()
        {

            var recipeTwo = new AddRecipeRequest
            {
                Name = "RecipeTwo",
                Description = "Description",
                UserID = 1,
                CategoryId = 1,
                IngredientsList = new List<GetIngredientResponse>
                {
                }
            };

            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.AddRecipe(recipeTwo));
        }
    }
}
