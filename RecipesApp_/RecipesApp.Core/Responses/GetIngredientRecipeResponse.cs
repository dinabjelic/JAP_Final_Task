using RecipesApp.Common.Enums;
using RecipesApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Core.Models
{
    public class GetIngredientRecipeResponse
    {
        public UnitMeasureType Measure { get; set; }
        public int Quantity { get; set; }
        public double IngredientPrice { get; set; }
        public double TotalCost { get; set; }
        public GetIngredientResponse Ingredients { get; set; }


    }
}
