using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipesApp.Database.Migrations
{
    public partial class CreateProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE GetRecipes
                                   AS 
                                   BEGIN
                                   SELECT R.Id, R.Name, R.Price , COUNT(IngredientsId)  as 'Numberofingredients'
                                   FROM IngredientsRecepies as IR
                                   INNER JOIN Recipes as R 
                                   ON IR.RecipesId= R.Id
                                   GROUP BY R.Id, R.Price, R.Name
                                   HAVING COUNT(IngredientsId) >= 4
                                   ORDER BY R.Price DESC
                                   END");
            migrationBuilder.Sql(@"CREATE PROCEDURE GetAllRecipes
                                   AS
                                   BEGIN
                                   SELECT R.Name AS 'RecipeName', RC.Name AS 'CategoryName', R.Price
                                   FROM Recipes as R 
                                   INNER JOIN RecipesCategoryRecipes as RCR
                                   ON R.Id= RCR.RecipesId
                                   INNER JOIN  RecipesCategories as RC
                                   ON RCR.RecipesCategoryId= RC.Id
                                   ORDER BY R.Price DESC 
                                   END");
            migrationBuilder.Sql(@"CREATE PROCEDURE GetIngredients 
                                   @MeasureType int, 
                                   @MinQuantity int, 
                                   @MaxQuantity int
                                   AS
                                   BEGIN
                                   SELECT TOP 10 I.Name AS 'IngredientName', COUNT(IngredientsId) AS 'Count'
                                   FROM IngredientsRecepies as IR
                                   INNER JOIN Ingredients as I
                                   ON IR.IngredientsId= I.Id
                                   WHERE @MeasureType= I.Measure 
                                   GROUP BY IngredientsId, I.Name
                                   HAVING 
                                        @MinQuantity= MIN(IR.Quantity)
                                   OR   @MaxQuantity= MAX(IR.Quantity)
                                   ORDER BY COUNT(IngredientsId) DESC
                                   END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop procedure GetRecipes");
            migrationBuilder.Sql("drop procedure GetAllRecipes");
            migrationBuilder.Sql("drop procedure GetIngredients");
        }
    }
}

