using RecipesApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Core.Requests
{
    public class AddIngredientRequest
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public UnitMeasureType Measure { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
