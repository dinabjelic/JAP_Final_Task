using RecipesApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Models
{
    public class AddRecipeRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; } 
        public double Price { get; set; }
        public string Description { get; set; }
        public string IngredientName { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        //public List<IngredientsModel> ingredientsList { get; set; } //ovaj model se koristio za dodavanje recepta na frontendu
        public List<GetIngredientResponse> IngredientsList { get; set; } 


    }
}
