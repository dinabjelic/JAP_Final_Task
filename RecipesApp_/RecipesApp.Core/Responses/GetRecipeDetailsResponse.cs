using RecipesApp.Core.Models;
using System.Collections.Generic;

namespace RecipesApp.Models
{
    public class GetRecipeDetailsResponse
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<GetIngredientRecipeResponse> IngredientRecipes { get; set; }
    }
}
