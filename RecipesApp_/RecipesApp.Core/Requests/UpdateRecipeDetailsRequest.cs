using RecipesApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Core.Requests
{
    public class UpdateRecipeDetailsRequest
    {
        public int RecipesId { get; set; }
        public int IngredientsId { get; set; }
        public int Quantity { get; set; }
        public UnitMeasureType Measure { get; set; }
    }
}
