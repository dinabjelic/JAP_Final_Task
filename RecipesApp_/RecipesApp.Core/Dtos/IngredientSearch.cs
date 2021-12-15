using RecipesApp.Common.Enums;
using RecipesApp.Core.Helpers;

namespace RecipesApp.Core.Dtos
{
    public class IngredientSearch:PaginationParams
    {
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public UnitMeasureType? Measure { get; set; }
        public int? number { get; set; }
    }
}
