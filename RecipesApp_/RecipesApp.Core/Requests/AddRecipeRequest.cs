using RecipesApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Models
{
    public class AddRecipeRequest
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int UserID { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string IngredientName { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public List<GetIngredientResponse> IngredientsList { get; set; } 


    }
}
