using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Models
{
    public class GetCategoryRecipeResponse
    {
        public int RecipesCategoryId { get; set; }
        public int RecipeId { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
