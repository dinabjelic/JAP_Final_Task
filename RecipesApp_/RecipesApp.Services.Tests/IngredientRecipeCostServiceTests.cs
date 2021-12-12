using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using RecipesApp.Common.Enums;
using RecipesApp.Core.Models;
using RecipesApp.Database;
using RecipesApp.Models;
using RecipesApp.Services.Interfaces;
using RecipesApp.Services.Services;
using System.Collections.Generic;
using System.Linq;

namespace RecipesApp.Services.Tests
{
    [TestFixture]
    public class IngredientRecipeCostServiceTests
    {
        private DbContextOptions<RecipesDbContext> _options;
        private RecipesDbContext _context;
        private IIngredientRecipeCostService _ingredientRecipeCostService;

        public IngredientRecipeCostServiceTests()
        {
            _options = new DbContextOptionsBuilder<RecipesDbContext>()
              .UseInMemoryDatabase(databaseName: "RecipesDB").Options;
            _context = new RecipesDbContext(_options);
            _ingredientRecipeCostService = new IngredientRecipeCostService();
        }

        //calculating ingredient cost
        [Test]
        public void IngredientCost_Recipe_CalculatingIngredientCostOne()
        {

            var list = new List<GetIngredientRecipeResponse>();
            var ingredients = new GetIngredientResponse
            {
                Id = 12,
                Measure = UnitMeasureType.gr,
                Name = "Ingredient 12",
                Price = 5,
                Quantity = 1000
            };
            list.Add(new GetIngredientRecipeResponse
            {
                Ingredients = ingredients,
                Measure = UnitMeasureType.gr,
                Quantity = 1000
            });
            var recipe = new GetRecipeDetailsResponse
            {
                RecipeId = 1,
                Description = "Description",
                Name = "Recipe 1",
                IngredientRecipes = list,

            };

            var realPrice = _ingredientRecipeCostService.IngredientRecipeCost(recipe);
            var expectePrice = (list.FirstOrDefault().Quantity * ingredients.Price) / ingredients.Quantity;

            Assert.AreEqual(expectePrice, realPrice);
        }

        [Test]
        public void IngredientCost_Recipe_CalculatingIngredientCostTwo()
        {
            var recipe = new GetRecipeDetailsResponse
            {
                RecipeId = 2,
                Description = "Description",
                Name = "Recipe 2",
                IngredientRecipes = new List<GetIngredientRecipeResponse>()
                {
                    new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 13,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 13",
                            Price = 22.5,
                            Quantity = 6000
                        }
                    },
                }
            };

            var realPrice = _ingredientRecipeCostService.IngredientRecipeCost(recipe);
            var expectedPrice = 1.875;
            Assert.AreEqual(expectedPrice, realPrice);
        }

        [Test]
        public void IngredientCost_Recipe_CalculatingIngredientCostThree()
        {

            var list = new List<GetIngredientRecipeResponse>();
            var ingredients = new GetIngredientResponse
            {
                Id = 12,
                Measure = UnitMeasureType.gr,
                Name = "Ingredient 12",
                Price = 3,
                Quantity = 1000
            };
            list.Add(new GetIngredientRecipeResponse
            {
                Ingredients = ingredients,
                Measure = UnitMeasureType.gr,
                Quantity = 1000
            });
            var recipe = new GetRecipeDetailsResponse
            {
                RecipeId = 1,
                Description = "Description",
                Name = "Recipe 1",
                IngredientRecipes = list,

            };

            var realPrice = _ingredientRecipeCostService.IngredientRecipeCost(recipe);
            var expectePrice = (list.FirstOrDefault().Quantity * ingredients.Price) / ingredients.Quantity;

            Assert.AreEqual(expectePrice, realPrice);
        }

        //calculating recipe cost
        [Test]
        public void RecipeCost_Recipe_CalculatingIngredientCostOne()
        {
            var recipe = new GetRecipeDetailsResponse
            {
                RecipeId = 2,
                Description = "Description",
                Name = "Recipe 2",
                IngredientRecipes = new List<GetIngredientRecipeResponse>()
                {
                    new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 13,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 13",
                            Price = 22.5,
                            Quantity = 6000
                        }
                    },
                    new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 14,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 14",
                            Price = 5,
                            Quantity = 1000
                        }
                    }
                }
            };

            var realPrice = _ingredientRecipeCostService.IngredientRecipeCost(recipe);
            var expectedPrice = 4.375;

            Assert.AreEqual(expectedPrice, realPrice);
        }

        [Test]
        public void RecipeCost_Recipe_CalculatingIngredientCostTwo()
        {

            var recipe = new GetRecipeDetailsResponse
            {
                RecipeId = 2,
                Description = "Description",
                Name = "Recipe 2",
                IngredientRecipes = new List<GetIngredientRecipeResponse>()
                {
                    new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 13,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 13",
                            Price = 22.5,
                            Quantity = 6000
                        }
                    },
                    new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 14,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 14",
                            Price = 5,
                            Quantity = 1000
                        }
                    },
                     new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 15,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 14",
                            Price = 10,
                            Quantity = 6000
                        }
                    },
                      new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 16,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 14",
                            Price = 5,
                            Quantity = 400
                        }
                    }
                }
            };

            var realPrice = _ingredientRecipeCostService.IngredientRecipeCost(recipe);
            var expectePrice = 11.458299999999999;

            Assert.AreEqual(expectePrice, realPrice);

        }

        [Test]
        public void RecipeCost_Recipe_CalculatingIngredientCostThree()
        {

            var recipe = new GetRecipeDetailsResponse
            {
                RecipeId = 2,
                Description = "Description",
                Name = "Recipe 2",
                IngredientRecipes = new List<GetIngredientRecipeResponse>()
                {
                    new GetIngredientRecipeResponse
                    {
                        Measure = UnitMeasureType.gr,
                        Quantity = 500,
                        Ingredients= new GetIngredientResponse
                        {
                            Id = 13,
                            Measure = UnitMeasureType.gr,
                            Name = "Ingredient 13",
                            Price = 22.5,
                            Quantity = 6000
                        }
                    },
                }
            };

            var realPrice = _ingredientRecipeCostService.IngredientRecipeCost(recipe);
            var expectedPrice = 1.875;

            Assert.AreEqual(expectedPrice, realPrice);
        }
    }
}
