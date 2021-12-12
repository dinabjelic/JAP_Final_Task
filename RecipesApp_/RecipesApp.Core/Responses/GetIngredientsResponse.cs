using RecipesApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Models
{
    public class GetIngredientsResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public UnitMeasureType Measure { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
