using Microsoft.EntityFrameworkCore;
using MoreLinq;
using RecipesApp.Common.Enums;
using RecipesApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Database.DataSeed
{
    public static class IngredientRecipeSeed
    {
        public static void SeedIngredientRecipes(this ModelBuilder builder)
        {
            Random random = new Random();
            List<IngredientRecipe> ingredientRecipes = new();

            List<UnitMeasureType> unitMeasures = new()
            {
                UnitMeasureType.kg,
                UnitMeasureType.gr,
                UnitMeasureType.l,
                UnitMeasureType.ml
            };

            for(int i=1;i<=100;i++)
            {
                ingredientRecipes.Add(new IngredientRecipe
                {
                    RecipesId = random.Next(1, 100),
                    IngredientsId = random.Next(1, 100),
                    Measure = unitMeasures[random.Next(0, 4)],
                    Quantity = (int)(random.Next(1, 50) + random.NextDouble())
                });
            }
            ingredientRecipes = ingredientRecipes.DistinctBy(x => new { x.RecipesId, x.IngredientsId}).ToList();
            builder.Entity<IngredientRecipe>().HasData(ingredientRecipes);
        }
    }
}
