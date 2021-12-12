using Microsoft.EntityFrameworkCore;
using RecipesApp.Common.Enums;
using RecipesApp.Core.Helpers;
using RecipesApp.Database.Entities;
using System;
using System.Collections.Generic;

namespace RecipesApp.Database.DataSeed
{
    public static class IngredientSeed
    {
        public static void SeedIngredients(this ModelBuilder builder)
        {
            Random random = new Random();
            List<Ingredient> ingredients = new();

            List<string> ingredientNames = new() { 
                "Sphagetti", 
                "Ketchup", 
                "Cheeze", 
                "Green salad", 
                "Meat", 
                "Sugar" 
            };

            List<UnitMeasureType> unitMeasures = new() {
                UnitMeasureType.kg, 
                UnitMeasureType.gr, 
                UnitMeasureType.l, 
                UnitMeasureType.ml 
            };

            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);

            for(int i=1;i<=100;i++)
            {
                ingredients.Add(new Ingredient
                {
                    Id = i,
                    Name = ingredientNames[i % 6] + i.ToString(),
                    Price = (float)Math.Round(random.Next(1, 50) + random.NextDouble(), 2),
                    Quantity = random.Next(1, 50),
                    Measure = unitMeasures[random.Next(0, 4)],
                    CreatedDate = DateGenerator.GenerateRandomDate(startDate, endDate)
                });
            }

            builder.Entity<Ingredient>().HasData(ingredients);
        }
    }
}
