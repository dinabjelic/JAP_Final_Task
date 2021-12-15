using RecipesApp.Common.Enums;

namespace RecipesApp.Core.Requests
{
    public class IngredientRequest
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public UnitMeasureType Measure { get; set; }
        public int Quantity { get; set; }
    }
}
