using System;
using System.ComponentModel.DataAnnotations;

namespace RecipesApp.Core.Requests
{
    public class AddCategoryRequest
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
