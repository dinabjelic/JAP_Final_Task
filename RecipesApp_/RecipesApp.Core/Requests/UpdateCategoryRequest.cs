using System;
using System.ComponentModel.DataAnnotations;

namespace RecipesApp.Core.Requests
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
