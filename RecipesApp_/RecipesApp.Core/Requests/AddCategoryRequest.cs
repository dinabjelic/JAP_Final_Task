using System;

namespace RecipesApp.Core.Requests
{
    public class AddCategoryRequest
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
