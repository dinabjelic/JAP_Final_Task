using RecipesApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Core.Models
{
    public class GetIngredientResponse
    {
        public int Id { get; set; } 
        public UnitMeasureType Measure { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
