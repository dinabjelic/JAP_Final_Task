using RecipesApp.Common.Enums;

namespace RecipesApp.Database.Entities
{
    public class IngredientRecipe
    {
        public Recipe Recipes { get; set; }
        public int RecipesId { get; set; }

        public Ingredient Ingredients { get; set; }
        public int IngredientsId { get; set; }

        public int Quantity { get; set; }
        public UnitMeasureType Measure { get; set; }

    }
}
