using System.Collections;
using System.Collections.Generic;

namespace RecipesApp.Database.Entities
{
    public class Recipe: BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public MyUser User { get; set; }
        public int UserID { get; set; }
        public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
    }
}
