namespace RecipesApp.Database.Entities
{
    public class RecipeCategoryRecipe
    {
        public RecipeCategory RecipesCategory { get; set; }
        public int RecipesCategoryId { get; set; }
        public Recipe Recipes { get; set; }
        public int RecipesId { get; set; }

    }
}
