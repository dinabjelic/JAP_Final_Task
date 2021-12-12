using RecipesApp.Common.Enums;
using System;

namespace RecipesApp.Core.Requests
{
    public class UpdateIngredientRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public UnitMeasureType Measure { get; set; }
    }
}
