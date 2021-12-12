using Microsoft.EntityFrameworkCore;
using MoreLinq;
using RecipesApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipesApp.Database.DataSeed
{
    public static class RecipeCategoryRecipeSeed
    {
        public static void SeedRecipeCategoryRecipe(this ModelBuilder builder)
        {
            Random random = new Random();
            List<RecipeCategoryRecipe> recipeCategoryRecipes = new();
            
            for(int i=1;i<=100;i++)
            {
                recipeCategoryRecipes.Add(new RecipeCategoryRecipe
                {
                    RecipesId = random.Next(1, 100),
                    RecipesCategoryId = random.Next(1, 100)
                });
            }
            recipeCategoryRecipes = recipeCategoryRecipes.DistinctBy(x => new { x.RecipesId, x.RecipesCategoryId }).ToList();
            builder.Entity<RecipeCategoryRecipe>().HasData(recipeCategoryRecipes);
        }
    }
}
