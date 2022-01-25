using System;

namespace RecipesApp.Core.Responses
{
    public class GetRecipesResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
      
    }
}
