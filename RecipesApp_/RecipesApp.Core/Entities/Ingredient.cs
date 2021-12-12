using RecipesApp.Common.Enums;
using System.Collections.Generic;

namespace RecipesApp.Database.Entities
{
    public class Ingredient:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public UnitMeasureType Measure { get; set; } = UnitMeasureType.gr;
        public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
    }
}
