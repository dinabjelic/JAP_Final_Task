using RecipesApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
