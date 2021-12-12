using Microsoft.EntityFrameworkCore;
using RecipesApp.Core.Helpers;
using RecipesApp.Database.Entities;
using System;
using System.Collections.Generic;

namespace RecipesApp.Database.DataSeed
{
    public static class RecipeCategorySeed
    {
        public static void SeedRecipeCategories(this ModelBuilder builder)
        {
            Random random = new Random();

            List<string> categoryNames = new() { 
                "Breakfast recipes",
                "Dinner recipes", 
                "Lunch recipes", 
                "Appetizer recipes", 
                "Main-course recipes", 
                "Side-dish recipes", 
                "Dessert recipes", 
                "Holiday recipes" 
            };

            List<RecipeCategory> recipeCategory = new();
            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);

            for(int i=1;i<=100;i++)
            {
                recipeCategory.Add(new RecipeCategory
                {
                    Id = i,
                    Name = categoryNames[i % 8] + i.ToString(),
                    CreatedDate = DateGenerator.GenerateRandomDate(startDate, endDate)
                });
            }
            builder.Entity<RecipeCategory>().HasData(recipeCategory);
        }
    }
}
