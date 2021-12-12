using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Database.DataSeed;
using RecipesApp.Database.Entities;

namespace RecipesApp.Database
{
    public class RecipesDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public RecipesDbContext(DbContextOptions<RecipesDbContext> options)
          : base(options)
        {
        }

        public DbSet<MyUser> MyUsers { get; set; }
        public DbSet<IngredientRecipe> IngredientsRecepies { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeCategory> RecipesCategories { get; set; }
        public DbSet<RecipeCategoryRecipe> RecipesCategoryRecipes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IngredientRecipe>()
                .HasKey(pp => new { pp.RecipesId, pp.IngredientsId });

            modelBuilder.Entity<RecipeCategoryRecipe>()
                .HasKey(pp => new { pp.RecipesId, pp.RecipesCategoryId});

            modelBuilder.SeedRecipes();
            modelBuilder.SeedIngredients();
            modelBuilder.SeedRecipeCategories();
            modelBuilder.SeedIngredientRecipes();
            modelBuilder.SeedRecipeCategoryRecipe();
        }
    }
}
