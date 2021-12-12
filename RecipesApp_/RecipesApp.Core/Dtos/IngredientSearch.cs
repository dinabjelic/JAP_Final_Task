using RecipesApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Core.Dtos
{
    public class IngredientSearch
    {
        public string IngredientName { get; set; }
        public int? Quantity { get; set; }
        public UnitMeasureType? Measure { get; set; }
    }
}
