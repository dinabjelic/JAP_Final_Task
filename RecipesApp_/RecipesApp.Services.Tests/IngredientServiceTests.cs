using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using RecipesApp.Common.Enums;
using RecipesApp.Core.Requests;
using RecipesApp.Database;
using RecipesApp.Database.Entities;
using RecipesApp.Interfaces;
using RecipesApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace RecipesApp.Services.Tests
{
    [TestFixture]
    public class IngredientServiceTests
    {
        private DbContextOptions<RecipesDbContext> _options;
        private RecipesDbContext _context;
        private IIngredientService _ingredientService;

        public IngredientServiceTests()
        {
            _options = new DbContextOptionsBuilder<RecipesDbContext>()
             .UseInMemoryDatabase(databaseName: "RecipesDB").Options;
            _context = new RecipesDbContext(_options);
            var mapperConfiguration = new MapperConfiguration(x => { x.CreateMap<Ingredient, GetIngredientsResponse>().ReverseMap(); });
            _ingredientService = new IngredientService(_context,mapperConfiguration.CreateMapper());
        }
       
        [Test]
        public async Task AddRecipe_RecipeOneOneIngredient_RecipeAdded()
        {
            var ingredients = new List<IngredientRequest>
            {
                new IngredientRequest
                {
                    IngredientId=1,
                    RecipeId =1,
                    Quantity=200,
                    Measure= UnitMeasureType.gr,
                }
            };

            await _ingredientService.NewIngredient(ingredients);

            var recipeFromDb = await _context.IngredientsRecepies.Where(x=>x.RecipesId ==1 && x.IngredientsId==1).ToListAsync();

            Assert.True(recipeFromDb.Any());
        }

        [Test]
        public async Task AddRecipe_RecipeOneOTwoIngredients_RecipeAdded()
        {
            var ingredients = new List<IngredientRequest>
            {
                new IngredientRequest
                {
                    IngredientId=2,
                    RecipeId =2,
                    Quantity=200,
                    Measure= UnitMeasureType.gr,
                },
                new IngredientRequest
                {
                    IngredientId=3,
                    RecipeId =3,
                    Quantity=200,
                    Measure= UnitMeasureType.gr,
                }
            };

            await _ingredientService.NewIngredient(ingredients);

            var recipeFromDbOne = await _context.IngredientsRecepies.Where(x => x.RecipesId == 2 && x.IngredientsId == 2).ToListAsync();
            var recipeFromDbTwo = await _context.IngredientsRecepies.Where(x => x.RecipesId == 3 && x.IngredientsId == 3).ToListAsync();


            Assert.True(recipeFromDbOne.Any());
            Assert.True(recipeFromDbTwo.Any());

        }
    }
}
