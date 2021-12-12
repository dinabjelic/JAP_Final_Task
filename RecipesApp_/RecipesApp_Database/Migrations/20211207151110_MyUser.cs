using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipesApp.Database.Migrations
{
    public partial class MyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 59, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 70, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 74, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 29, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 34, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 65, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 45, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 99, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 28, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 85, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 94, 16 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 52, 17 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 71, 17 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 57, 18 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 76, 19 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 84, 20 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 61, 21 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 66, 21 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 38, 22 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 52, 22 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 73, 22 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 16, 23 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 88, 23 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 78, 24 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 87, 24 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 13, 26 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 16, 29 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 87, 30 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 22, 31 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 65, 31 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 81, 32 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 24, 33 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 31, 33 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 67, 33 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 54, 34 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 63, 34 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 6, 36 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 30, 36 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 57, 36 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 28, 37 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 54, 38 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 29, 40 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 94, 42 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 35, 43 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 30, 47 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 32, 48 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 17, 49 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 19, 50 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 29, 53 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 56, 53 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 92, 53 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 11, 56 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 8, 57 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 85, 57 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 42, 60 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 77, 61 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 56, 62 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 87, 62 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 56, 63 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 50, 64 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 11, 65 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 84, 66 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 80, 67 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 93, 67 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 4, 69 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 25, 69 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 69, 70 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 10, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 37, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 1, 76 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 8, 77 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 44, 77 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 90, 77 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 56, 78 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 10, 79 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 27, 81 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 35, 81 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 43, 82 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 5, 87 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 11, 89 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 64, 89 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 80, 89 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 83, 91 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 85, 91 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 88, 91 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 6, 93 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 57, 93 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 62, 93 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 40, 94 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 15, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 49, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 70, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 93, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 46, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 58, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 96, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 21, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 24, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 62, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 67, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 32, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 87, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 97, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 76, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 90, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 86, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 8, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 11, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 19, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 58, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 70, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 3, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 98, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 4, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 16, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 31, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 36, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 30, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 43, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 54, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 64, 41 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 49, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 52, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 11, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 72, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 99, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 96, 48 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 52, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 46, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 22, 52 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 14, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 57, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 57, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 78, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 51, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 52, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 76, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 87, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 21, 59 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 59, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 71, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 13, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 75, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 46, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 60, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 19, 70 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 69, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 73, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 74, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 2, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 54, 74 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 43, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 34, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 95, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 67, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 76, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 28, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 67, 80 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 11, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 57, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 86, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 90, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 40, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 67, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 9, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 32, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 70, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 10, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 43, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 45, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 12, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 15, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 39, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 81, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 95, 99 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 31, 9, 59, 0, 0, DateTimeKind.Unspecified), 4, 30.940000534057617, 15 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 10, 4, 24, 0, 0, DateTimeKind.Unspecified), 4, 16.370000839233398, 35 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 3, 0, 0, DateTimeKind.Unspecified), 16.579999923706055, 38 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 21, 1, 51, 0, 0, DateTimeKind.Unspecified), 1, 42.25, 6 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 20, 9, 48, 0, 0, DateTimeKind.Unspecified), 21.340000152587891, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 17, 6, 24, 0, 0, DateTimeKind.Unspecified), 1, 25.799999237060547, 16 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 8, 15, 35, 0, 0, DateTimeKind.Unspecified), 6.9499998092651367, 14 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 26, 22, 48, 0, 0, DateTimeKind.Unspecified), 32.029998779296875, 13 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 22, 3, 7, 0, 0, DateTimeKind.Unspecified), 1, 27.440000534057617, 26 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 10, 10, 8, 0, 0, DateTimeKind.Unspecified), 2, 21.270000457763672, 35 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 16, 4, 26, 0, 0, DateTimeKind.Unspecified), 36.060001373291016, 13 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 2, 39.369998931884766, 13 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 9, 12, 51, 0, 0, DateTimeKind.Unspecified), 31.479999542236328, 23 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 18, 2, 50, 0, 0, DateTimeKind.Unspecified), 8.9799995422363281, 13 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 24, 18, 15, 0, 0, DateTimeKind.Unspecified), 2, 31.180000305175781, 23 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 5, 14, 33, 0, 0, DateTimeKind.Unspecified), 2, 5.869999885559082, 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 4, 7, 10, 0, 0, DateTimeKind.Unspecified), 16.110000610351562, 7 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 29, 7, 6, 0, 0, DateTimeKind.Unspecified), 1, 36.069999694824219, 35 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 10, 6, 4, 0, 0, DateTimeKind.Unspecified), 32.560001373291016, 29 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 6, 21, 58, 0, 0, DateTimeKind.Unspecified), 4, 27.940000534057617, 17 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 23, 9, 57, 0, 0, DateTimeKind.Unspecified), 1, 34.959999084472656, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 29, 4, 9, 0, 0, DateTimeKind.Unspecified), 4, 29.770000457763672, 26 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 24, 12, 47, 0, 0, DateTimeKind.Unspecified), 1, 10.729999542236328, 21 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 1, 3, 10, 0, 0, DateTimeKind.Unspecified), 3, 40.349998474121094, 14 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 3, 5, 27, 0, 0, DateTimeKind.Unspecified), 4, 2.9800000190734863, 4 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 1, 6, 8, 0, 0, DateTimeKind.Unspecified), 4, 13.850000381469727, 30 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 23, 12, 2, 0, 0, DateTimeKind.Unspecified), 4, 38.299999237060547, 42 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 25, 7, 57, 0, 0, DateTimeKind.Unspecified), 4, 20.809999465942383, 13 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 28, 20, 19, 0, 0, DateTimeKind.Unspecified), 1, 41.720001220703125, 33 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 9, 12, 37, 0, 0, DateTimeKind.Unspecified), 32.880001068115234, 35 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 5, 14, 28, 0, 0, DateTimeKind.Unspecified), 30.569999694824219, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 11, 14, 14, 0, 0, DateTimeKind.Unspecified), 2, 33.479999542236328, 18 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 14, 18, 54, 0, 0, DateTimeKind.Unspecified), 14.710000038146973, 21 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 30, 10, 35, 0, 0, DateTimeKind.Unspecified), 43.669998168945312, 24 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 19, 19, 40, 0, 0, DateTimeKind.Unspecified), 18.670000076293945, 19 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 14, 9, 58, 0, 0, DateTimeKind.Unspecified), 46.919998168945312, 8 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 3, 8, 5, 0, 0, DateTimeKind.Unspecified), 23.729999542236328, 20 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 24, 20, 27, 0, 0, DateTimeKind.Unspecified), 1, 34.150001525878906, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 24, 15, 26, 0, 0, DateTimeKind.Unspecified), 4, 14.510000228881836, 4 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 27, 23, 5, 0, 0, DateTimeKind.Unspecified), 2, 31.610000610351562, 44 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 22, 14, 4, 0, 0, DateTimeKind.Unspecified), 4, 47.549999237060547, 16 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 6, 17, 7, 0, 0, DateTimeKind.Unspecified), 1, 19.700000762939453, 40 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 21, 21, 58, 0, 0, DateTimeKind.Unspecified), 3, 12.829999923706055, 38 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 13, 5, 21, 0, 0, DateTimeKind.Unspecified), 4, 25.430000305175781, 31 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 25, 0, 38, 0, 0, DateTimeKind.Unspecified), 3, 21.840000152587891, 26 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 28, 0, 45, 0, 0, DateTimeKind.Unspecified), 4.25, 30 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 10, 11, 46, 0, 0, DateTimeKind.Unspecified), 2, 25.270000457763672, 14 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 8, 23, 37, 0, 0, DateTimeKind.Unspecified), 4, 30.799999237060547, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 16, 0, 0, DateTimeKind.Unspecified), 2, 39.080001831054688, 17 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 17, 18, 43, 0, 0, DateTimeKind.Unspecified), 3, 30.459999084472656, 49 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 12, 9, 43, 0, 0, DateTimeKind.Unspecified), 3, 46.229999542236328, 43 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 25, 0, 0, DateTimeKind.Unspecified), 3, 19.239999771118164, 33 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 31, 16, 59, 0, 0, DateTimeKind.Unspecified), 3, 44.389999389648438, 14 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 28, 4, 35, 0, 0, DateTimeKind.Unspecified), 4, 5.9699997901916504, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 6, 0, 0, DateTimeKind.Unspecified), 1, 47.180000305175781, 10 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 31, 5, 49, 0, 0, DateTimeKind.Unspecified), 2, 21.450000762939453, 28 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 15, 15, 36, 0, 0, DateTimeKind.Unspecified), 2, 31.030000686645508, 10 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 7, 6, 53, 0, 0, DateTimeKind.Unspecified), 3, 5.2399997711181641, 4 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 16, 20, 24, 0, 0, DateTimeKind.Unspecified), 3, 42.759998321533203, 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 20, 3, 40, 0, 0, DateTimeKind.Unspecified), 20.75, 38 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 22, 0, 0, DateTimeKind.Unspecified), 1, 31.430000305175781, 23 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 12, 7, 37, 0, 0, DateTimeKind.Unspecified), 3, 27.420000076293945, 33 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 30, 2, 29, 0, 0, DateTimeKind.Unspecified), 2, 43.630001068115234, 22 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 15, 14, 29, 0, 0, DateTimeKind.Unspecified), 2, 14.880000114440918, 18 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 5, 19, 39, 0, 0, DateTimeKind.Unspecified), 33.430000305175781, 12 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 5, 14, 12, 0, 0, DateTimeKind.Unspecified), 3.25, 38 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 20, 15, 20, 0, 0, DateTimeKind.Unspecified), 17.329999923706055, 47 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 8, 2, 15, 0, 0, DateTimeKind.Unspecified), 48.369998931884766, 15 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 27, 7, 10, 0, 0, DateTimeKind.Unspecified), 21.940000534057617, 25 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 11, 8, 16, 0, 0, DateTimeKind.Unspecified), 1, 49.349998474121094, 44 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 6, 6, 28, 0, 0, DateTimeKind.Unspecified), 18.370000839233398, 27 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 13, 10, 42, 0, 0, DateTimeKind.Unspecified), 3, 40.630001068115234, 34 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 3, 21.540000915527344, 9 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 16, 6, 58, 0, 0, DateTimeKind.Unspecified), 26.399999618530273, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 13, 7, 54, 0, 0, DateTimeKind.Unspecified), 1, 34.819999694824219, 44 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 49, 0, 0, DateTimeKind.Unspecified), 24.329999923706055, 42 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 11, 6, 11, 0, 0, DateTimeKind.Unspecified), 2, 17.239999771118164, 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 14, 7, 26, 0, 0, DateTimeKind.Unspecified), 2, 19.370000839233398, 24 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 5, 2, 31, 0, 0, DateTimeKind.Unspecified), 4, 27.040000915527344, 49 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 6, 4, 41, 0, 0, DateTimeKind.Unspecified), 35.299999237060547, 42 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 22, 18, 22, 0, 0, DateTimeKind.Unspecified), 32.970001220703125, 45 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 17, 12, 24, 0, 0, DateTimeKind.Unspecified), 1, 10.340000152587891, 34 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 10, 3, 41, 0, 0, DateTimeKind.Unspecified), 37.130001068115234, 15 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Measure", "Price" },
                values: new object[] { new DateTime(2021, 7, 12, 1, 35, 0, 0, DateTimeKind.Unspecified), 1, 24.690000534057617 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 28, 2, 54, 0, 0, DateTimeKind.Unspecified), 4, 26.040000915527344, 7 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 3, 0, 0, DateTimeKind.Unspecified), 1, 31.360000610351562, 30 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 8, 21, 14, 0, 0, DateTimeKind.Unspecified), 2, 3.8599998950958252, 22 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 15, 14, 18, 0, 0, DateTimeKind.Unspecified), 2, 21.520000457763672, 33 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 24, 18, 28, 0, 0, DateTimeKind.Unspecified), 2, 48.180000305175781, 28 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 17, 13, 50, 0, 0, DateTimeKind.Unspecified), 3, 21.430000305175781, 16 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 29, 18, 22, 0, 0, DateTimeKind.Unspecified), 1, 29.0, 29 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 25, 1, 11, 0, 0, DateTimeKind.Unspecified), 4.320000171661377, 42 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 7, 0, 3, 0, 0, DateTimeKind.Unspecified), 4, 16.950000762939453, 9 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Measure", "Price" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 46, 0, 0, DateTimeKind.Unspecified), 2, 9.2799997329711914 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 8, 4, 43, 0, 0, DateTimeKind.Unspecified), 2, 19.870000839233398, 19 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 14, 6, 26, 0, 0, DateTimeKind.Unspecified), 1, 45.200000762939453, 30 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 5, 14, 37, 0, 0, DateTimeKind.Unspecified), 24.920000076293945, 10 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 4, 7, 28, 0, 0, DateTimeKind.Unspecified), 1, 7.2300000190734863, 31 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 5, 9, 41, 0, 0, DateTimeKind.Unspecified), 4, 37.130001068115234, 49 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 20, 10, 25, 0, 0, DateTimeKind.Unspecified), 4, 38.349998474121094, 48 });

            migrationBuilder.UpdateData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 13, 41 },
                column: "Measure",
                value: 1);

            migrationBuilder.UpdateData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 3, 45 },
                columns: new[] { "Measure", "Quantity" },
                values: new object[] { 2, 20 });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Quantity" },
                values: new object[,]
                {
                    { 53, 90, 4, 29 },
                    { 54, 10, 1, 14 },
                    { 69, 3, 3, 17 },
                    { 96, 28, 4, 27 },
                    { 61, 99, 2, 9 },
                    { 88, 94, 3, 24 },
                    { 97, 74, 4, 48 },
                    { 11, 91, 3, 43 },
                    { 65, 24, 1, 39 },
                    { 50, 46, 4, 15 },
                    { 37, 26, 3, 40 },
                    { 22, 17, 4, 17 },
                    { 21, 53, 4, 38 },
                    { 25, 53, 1, 36 },
                    { 73, 65, 2, 21 },
                    { 34, 20, 1, 3 },
                    { 41, 25, 2, 44 },
                    { 22, 98, 2, 40 },
                    { 56, 65, 2, 17 },
                    { 88, 58, 1, 6 },
                    { 79, 86, 2, 9 },
                    { 73, 48, 4, 38 },
                    { 30, 82, 4, 21 },
                    { 28, 42, 3, 39 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Quantity" },
                values: new object[,]
                {
                    { 72, 29, 3, 34 },
                    { 64, 57, 1, 47 },
                    { 66, 11, 3, 23 },
                    { 15, 23, 4, 3 },
                    { 9, 24, 1, 38 },
                    { 11, 44, 4, 13 },
                    { 44, 48, 1, 15 },
                    { 49, 25, 3, 16 },
                    { 73, 14, 1, 21 },
                    { 77, 84, 3, 46 },
                    { 18, 41, 3, 22 },
                    { 52, 78, 3, 22 },
                    { 50, 87, 3, 48 },
                    { 42, 26, 2, 37 },
                    { 88, 95, 3, 41 },
                    { 32, 98, 3, 27 },
                    { 60, 38, 1, 48 },
                    { 17, 56, 3, 30 },
                    { 75, 72, 4, 2 },
                    { 17, 72, 4, 48 },
                    { 3, 6, 2, 18 },
                    { 47, 95, 2, 43 },
                    { 19, 63, 3, 37 },
                    { 43, 70, 4, 9 },
                    { 69, 32, 2, 15 },
                    { 30, 38, 1, 26 },
                    { 42, 74, 4, 46 },
                    { 4, 2, 2, 49 },
                    { 85, 32, 2, 4 },
                    { 91, 4, 4, 46 },
                    { 4, 40, 2, 20 },
                    { 40, 11, 2, 21 },
                    { 83, 39, 4, 11 },
                    { 19, 31, 4, 22 },
                    { 13, 76, 2, 19 },
                    { 17, 60, 2, 31 },
                    { 15, 56, 2, 30 },
                    { 36, 7, 4, 41 },
                    { 49, 15, 4, 11 },
                    { 16, 49, 1, 28 },
                    { 43, 40, 2, 42 },
                    { 92, 24, 3, 35 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Quantity" },
                values: new object[,]
                {
                    { 14, 59, 4, 48 },
                    { 83, 54, 1, 8 },
                    { 67, 74, 4, 10 },
                    { 1, 68, 1, 1 },
                    { 68, 73, 2, 49 },
                    { 84, 74, 3, 30 },
                    { 31, 5, 2, 21 },
                    { 74, 24, 2, 12 },
                    { 84, 72, 1, 40 },
                    { 4, 67, 2, 47 },
                    { 63, 68, 4, 11 },
                    { 77, 94, 3, 34 },
                    { 38, 99, 1, 44 },
                    { 25, 89, 2, 8 },
                    { 38, 11, 3, 20 },
                    { 41, 86, 3, 5 },
                    { 49, 9, 4, 14 },
                    { 10, 56, 4, 30 },
                    { 86, 21, 3, 1 },
                    { 10, 76, 4, 16 },
                    { 55, 17, 4, 48 },
                    { 20, 78, 1, 32 },
                    { 39, 4, 1, 45 },
                    { 97, 17, 4, 39 },
                    { 97, 45, 2, 49 },
                    { 63, 30, 2, 7 },
                    { 58, 25, 4, 24 },
                    { 4, 7, 2, 8 },
                    { 46, 53, 4, 3 },
                    { 52, 39, 3, 14 },
                    { 18, 15, 4, 24 },
                    { 4, 96, 1, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 12, 17, 43, 0, 0, DateTimeKind.Unspecified), 27.698975284909352 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 14, 11, 26, 0, 0, DateTimeKind.Unspecified), 95.267467022532344 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 9, 18, 9, 0, 0, DateTimeKind.Unspecified), 1.2938517179777156 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 92.187437617772929 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 1, 7, 44, 0, 0, DateTimeKind.Unspecified), 57.721786860712704 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 31, 21, 10, 0, 0, DateTimeKind.Unspecified), 15.561536073946177 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 23, 22, 9, 0, 0, DateTimeKind.Unspecified), 98.015425746336305 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 2, 2, 11, 0, 0, DateTimeKind.Unspecified), 42.69299847106123 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 8, 14, 2, 0, 0, DateTimeKind.Unspecified), 21.916963616347388 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 23, 7, 23, 0, 0, DateTimeKind.Unspecified), 13.557728200944945 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 15, 0, 0, DateTimeKind.Unspecified), 59.101095817564563 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 11, 15, 1, 0, 0, DateTimeKind.Unspecified), 37.533118328327831 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 28, 14, 57, 0, 0, DateTimeKind.Unspecified), 6.0677317870164904 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 28, 7, 6, 0, 0, DateTimeKind.Unspecified), 20.821717984891364 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 24, 11, 12, 0, 0, DateTimeKind.Unspecified), 4.3175474276382229 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 11, 8, 54, 0, 0, DateTimeKind.Unspecified), 46.443998097183183 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 16, 1, 29, 0, 0, DateTimeKind.Unspecified), 44.558220568372974 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 2, 13, 39, 0, 0, DateTimeKind.Unspecified), 86.790796480975487 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 23, 23, 35, 0, 0, DateTimeKind.Unspecified), 67.081768807993157 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 28, 3, 55, 0, 0, DateTimeKind.Unspecified), 6.1518042120858114 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 24, 11, 53, 0, 0, DateTimeKind.Unspecified), 38.64228930028262 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 2, 23, 58, 0, 0, DateTimeKind.Unspecified), 99.382203858989385 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 28, 3, 41, 0, 0, DateTimeKind.Unspecified), 62.435010502783122 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 30, 16, 37, 0, 0, DateTimeKind.Unspecified), 74.19177853045602 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 28, 20, 54, 0, 0, DateTimeKind.Unspecified), 66.906581870702368 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 17, 23, 5, 0, 0, DateTimeKind.Unspecified), 22.44292204288902 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 19, 12, 28, 0, 0, DateTimeKind.Unspecified), 85.440953369923378 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 8, 16, 39, 0, 0, DateTimeKind.Unspecified), 55.162762081326342 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 19, 17, 50, 0, 0, DateTimeKind.Unspecified), 33.416908602890054 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 14, 2, 26, 0, 0, DateTimeKind.Unspecified), 21.934388956024492 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 16, 3, 44, 0, 0, DateTimeKind.Unspecified), 10.102977735504032 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 21, 20, 21, 0, 0, DateTimeKind.Unspecified), 16.254205924111513 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), 26.706228824661221 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 11, 10, 39, 0, 0, DateTimeKind.Unspecified), 13.422862081054069 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 18, 22, 50, 0, 0, DateTimeKind.Unspecified), 16.631931918967485 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 20, 18, 44, 0, 0, DateTimeKind.Unspecified), 3.1244399976564758 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 26, 2, 8, 0, 0, DateTimeKind.Unspecified), 85.975977215904734 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 58, 0, 0, DateTimeKind.Unspecified), 18.949060704069705 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 26, 7, 10, 0, 0, DateTimeKind.Unspecified), 11.991197822611406 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 4, 17, 59, 0, 0, DateTimeKind.Unspecified), 91.621751782308223 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 4, 22, 24, 0, 0, DateTimeKind.Unspecified), 33.004242809957006 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 15, 2, 53, 0, 0, DateTimeKind.Unspecified), 16.129228606414621 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 6, 10, 39, 0, 0, DateTimeKind.Unspecified), 11.019549234313681 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 13, 6, 12, 0, 0, DateTimeKind.Unspecified), 59.999002665746495 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 27, 3, 57, 0, 0, DateTimeKind.Unspecified), 2.6960584757365558 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 12, 15, 14, 0, 0, DateTimeKind.Unspecified), 47.251544548781375 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 23, 8, 42, 0, 0, DateTimeKind.Unspecified), 87.124759948870519 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 14, 18, 19, 0, 0, DateTimeKind.Unspecified), 6.2764612321166604 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 25, 18, 19, 0, 0, DateTimeKind.Unspecified), 49.742147423206895 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 7, 16, 34, 0, 0, DateTimeKind.Unspecified), 13.912837045226636 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 3, 20, 56, 0, 0, DateTimeKind.Unspecified), 32.317638433686291 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 15, 22, 4, 0, 0, DateTimeKind.Unspecified), 4.0322496579178839 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 18, 4, 25, 0, 0, DateTimeKind.Unspecified), 88.091238002800964 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 17, 8, 39, 0, 0, DateTimeKind.Unspecified), 58.872681256790031 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 19, 19, 9, 0, 0, DateTimeKind.Unspecified), 27.59816237240944 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 12, 17, 45, 0, 0, DateTimeKind.Unspecified), 6.3343757806971555 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 20, 7, 44, 0, 0, DateTimeKind.Unspecified), 50.588952955132797 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 8, 1, 31, 0, 0, DateTimeKind.Unspecified), 61.093587567607678 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 94.022398534241319 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 15, 8, 38, 0, 0, DateTimeKind.Unspecified), 16.239766349196326 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 13, 8, 42, 0, 0, DateTimeKind.Unspecified), 11.122577372529813 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 18, 5, 30, 0, 0, DateTimeKind.Unspecified), 41.460546713536857 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 13, 8, 21, 0, 0, DateTimeKind.Unspecified), 17.77300077060843 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 23, 11, 35, 0, 0, DateTimeKind.Unspecified), 26.733054762581855 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 8, 3, 38, 0, 0, DateTimeKind.Unspecified), 92.901828001207591 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 27, 1, 53, 0, 0, DateTimeKind.Unspecified), 46.362595047039257 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 12, 5, 15, 0, 0, DateTimeKind.Unspecified), 86.001215413213345 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 16, 4, 18, 0, 0, DateTimeKind.Unspecified), 31.009592838589843 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 7, 8, 15, 0, 0, DateTimeKind.Unspecified), 96.125286750088108 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 2, 16, 27, 0, 0, DateTimeKind.Unspecified), 25.010631424379827 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 17, 6, 45, 0, 0, DateTimeKind.Unspecified), 44.722658367698386 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 17, 14, 31, 0, 0, DateTimeKind.Unspecified), 73.412835119484384 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 8, 6, 29, 0, 0, DateTimeKind.Unspecified), 64.130847096969774 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 22, 5, 36, 0, 0, DateTimeKind.Unspecified), 75.282111115419355 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 24, 5, 31, 0, 0, DateTimeKind.Unspecified), 52.960386266913446 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), 33.468263625385362 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 25, 13, 18, 0, 0, DateTimeKind.Unspecified), 59.883121926283053 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 17, 21, 29, 0, 0, DateTimeKind.Unspecified), 80.190853091977004 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 90.574626627645742 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 17, 5, 39, 0, 0, DateTimeKind.Unspecified), 86.109035780704133 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 23, 14, 23, 0, 0, DateTimeKind.Unspecified), 83.852052568854788 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 5, 18, 9, 0, 0, DateTimeKind.Unspecified), 95.360836135391537 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 11, 22, 19, 0, 0, DateTimeKind.Unspecified), 14.695424564040929 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 16, 1, 15, 0, 0, DateTimeKind.Unspecified), 47.501640731236733 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 11, 5, 30, 0, 0, DateTimeKind.Unspecified), 28.597564845158516 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 2, 5, 39, 0, 0, DateTimeKind.Unspecified), 13.820154577409921 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 4, 15, 56, 0, 0, DateTimeKind.Unspecified), 77.141705072550891 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 14, 1, 6, 0, 0, DateTimeKind.Unspecified), 80.38823083247442 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 20, 15, 30, 0, 0, DateTimeKind.Unspecified), 39.999029469675861 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 9, 5, 5, 0, 0, DateTimeKind.Unspecified), 82.03586194433079 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 3.9712648116849665 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 17, 0, 37, 0, 0, DateTimeKind.Unspecified), 22.961617114470162 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 24, 2, 28, 0, 0, DateTimeKind.Unspecified), 57.99013491905766 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 11, 22, 31, 0, 0, DateTimeKind.Unspecified), 77.985187620848976 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 25, 9, 17, 0, 0, DateTimeKind.Unspecified), 20.1174682258244 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 15, 16, 53, 0, 0, DateTimeKind.Unspecified), 11.394442841128653 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 2, 18, 31, 0, 0, DateTimeKind.Unspecified), 26.138156274397929 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 12, 23, 4, 0, 0, DateTimeKind.Unspecified), 18.582389334022249 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 6, 2, 34, 0, 0, DateTimeKind.Unspecified), 77.375502393755824 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 1, 2, 4, 0, 0, DateTimeKind.Unspecified), 28.942614300615439 });

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 8, 9, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 2, 9, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 10, 16, 27, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 7, 19, 59, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 10, 12, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 30, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 5, 19, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 18, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 17, 20, 41, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 19, 23, 17, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 20, 23, 38, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 4, 8, 9, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 3, 4, 22, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 11, 15, 42, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 26, 9, 18, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 6, 5, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 2, 3, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 19, 0, 54, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 21, 11, 35, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 10, 16, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 27, 16, 58, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 8, 1, 1, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 15, 7, 46, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 8, 17, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 12, 13, 54, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 10, 5, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 5, 10, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 26, 3, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 7, 2, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 31, 1, 27, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 13, 2, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 4, 22, 42, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 6, 21, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 16, 16, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 19, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 20, 8, 51, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 5, 19, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 3, 7, 42, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 30, 13, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 26, 3, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 24, 7, 17, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 11, 13, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 31, 17, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 5, 19, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 28, 14, 12, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 26, 10, 12, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 24, 20, 48, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 26, 8, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 11, 2, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 1, 22, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 2, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 17, 13, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 16, 19, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 28, 17, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 23, 17, 26, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 3, 8, 23, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 19, 1, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 2, 23, 8, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 24, 6, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 3, 6, 58, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 24, 12, 21, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 8, 15, 52, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 10, 7, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 15, 19, 14, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 4, 21, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 17, 0, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 26, 10, 24, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 15, 12, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 11, 20, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 9, 0, 26, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 1, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 30, 20, 14, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 20, 11, 34, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 24, 7, 41, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 15, 9, 18, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 5, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 5, 7, 24, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 8, 12, 34, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 9, 3, 7, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 18, 3, 41, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 14, 8, 27, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 2, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 16, 1, 24, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 29, 12, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 17, 2, 48, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 12, 4, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 23, 22, 38, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 26, 10, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 31, 7, 6, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 3, 20, 48, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 9, 1, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 29, 6, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 31, 15, 32, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 14, 15, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 13, 3, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 13, 22, 22, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 3, 22, 6, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 14, 13, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 98, 38 },
                    { 78, 12 },
                    { 1, 96 },
                    { 33, 91 },
                    { 98, 62 },
                    { 80, 63 },
                    { 64, 4 },
                    { 54, 37 },
                    { 63, 58 },
                    { 1, 83 },
                    { 43, 68 },
                    { 64, 13 },
                    { 56, 95 },
                    { 41, 79 },
                    { 42, 4 },
                    { 37, 85 },
                    { 82, 71 },
                    { 8, 62 },
                    { 95, 32 },
                    { 61, 44 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 71, 91 },
                    { 47, 94 },
                    { 59, 68 },
                    { 53, 71 },
                    { 44, 13 },
                    { 7, 83 },
                    { 11, 21 },
                    { 65, 78 },
                    { 30, 65 },
                    { 5, 95 },
                    { 31, 96 },
                    { 44, 5 },
                    { 72, 84 },
                    { 58, 98 },
                    { 29, 98 },
                    { 37, 86 },
                    { 87, 11 },
                    { 79, 49 },
                    { 84, 3 },
                    { 31, 26 },
                    { 43, 67 },
                    { 41, 73 },
                    { 83, 61 },
                    { 56, 5 },
                    { 34, 45 },
                    { 30, 34 },
                    { 70, 58 },
                    { 66, 94 },
                    { 94, 26 },
                    { 30, 33 },
                    { 31, 49 },
                    { 85, 8 },
                    { 61, 12 },
                    { 79, 5 },
                    { 80, 77 },
                    { 41, 53 },
                    { 37, 12 },
                    { 56, 43 },
                    { 59, 26 },
                    { 51, 72 },
                    { 65, 15 },
                    { 38, 67 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 17, 51 },
                    { 68, 82 },
                    { 74, 54 },
                    { 49, 32 },
                    { 25, 98 },
                    { 5, 92 },
                    { 9, 66 },
                    { 10, 18 },
                    { 67, 17 },
                    { 97, 11 },
                    { 4, 92 },
                    { 5, 43 },
                    { 45, 34 },
                    { 74, 42 },
                    { 13, 83 },
                    { 26, 75 },
                    { 47, 46 },
                    { 41, 82 },
                    { 51, 22 },
                    { 20, 30 },
                    { 26, 14 },
                    { 22, 10 },
                    { 29, 2 },
                    { 63, 22 },
                    { 82, 7 },
                    { 22, 20 },
                    { 66, 49 },
                    { 42, 93 },
                    { 84, 30 },
                    { 73, 8 },
                    { 54, 93 },
                    { 59, 53 },
                    { 37, 7 },
                    { 84, 62 },
                    { 3, 13 },
                    { 41, 39 },
                    { 96, 9 },
                    { 3, 38 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 69, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 91, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 49, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 54, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 38, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 66, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 73, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 18, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 49, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 22, 17 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 55, 17 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 97, 17 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 34, 20 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 86, 21 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 15, 23 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 9, 24 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 65, 24 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 74, 24 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 92, 24 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 41, 25 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 49, 25 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 58, 25 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 37, 26 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 42, 26 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 96, 28 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 72, 29 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 63, 30 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 19, 31 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 69, 32 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 85, 32 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 30, 38 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 60, 38 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 52, 39 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 83, 39 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 4, 40 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 43, 40 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 18, 41 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 28, 42 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 11, 44 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 97, 45 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 50, 46 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 44, 48 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 73, 48 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 16, 49 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 21, 53 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 25, 53 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 46, 53 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 83, 54 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 10, 56 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 15, 56 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 17, 56 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 64, 57 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 88, 58 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 14, 59 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 17, 60 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 19, 63 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 56, 65 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 73, 65 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 4, 67 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 1, 68 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 63, 68 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 43, 70 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 17, 72 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 75, 72 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 84, 72 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 68, 73 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 42, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 67, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 84, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 97, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 10, 76 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 13, 76 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 20, 78 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 52, 78 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 30, 82 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 77, 84 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 41, 86 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 79, 86 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 50, 87 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 25, 89 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 53, 90 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 11, 91 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 77, 94 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 88, 94 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 47, 95 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 88, 95 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 4, 96 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 22, 98 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 32, 98 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 38, 99 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 61, 99 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 84, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 64, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 56, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 79, 5 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 82, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 73, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 85, 8 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 96, 9 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 87, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 97, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 37, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 61, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 78, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 44, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 64, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 26, 14 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 65, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 67, 17 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 22, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 11, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 51, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 63, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 31, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 59, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 94, 26 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 20, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 84, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 49, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 95, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 30, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 30, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 45, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 54, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 98, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 41, 39 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 74, 42 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 56, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 61, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 34, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 47, 46 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 31, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 66, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 79, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 17, 51 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 41, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 59, 53 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 74, 54 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 63, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 70, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 83, 61 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 8, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 84, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 98, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 80, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 30, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 9, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 38, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 43, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 43, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 59, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 53, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 82, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 51, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 41, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 26, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 80, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 65, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 41, 79 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 41, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 68, 82 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 7, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 13, 83 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 72, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 37, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 37, 86 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 33, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 71, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 4, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 5, 92 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 42, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 54, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 47, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 66, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 5, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 56, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 31, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 25, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 58, 98 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 30, 19, 51, 0, 0, DateTimeKind.Unspecified), 3, 7.3400001525878906, 12 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 2, 19, 12, 0, 0, DateTimeKind.Unspecified), 1, 16.25, 39 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 30, 20, 3, 0, 0, DateTimeKind.Unspecified), 9.9700002670288086, 36 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 28, 13, 16, 0, 0, DateTimeKind.Unspecified), 3, 23.940000534057617, 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 50, 0, 0, DateTimeKind.Unspecified), 27.219999313354492, 26 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 27, 7, 50, 0, 0, DateTimeKind.Unspecified), 3, 40.319999694824219, 22 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 27, 0, 30, 0, 0, DateTimeKind.Unspecified), 48.740001678466797, 33 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 8, 14, 33, 0, 0, DateTimeKind.Unspecified), 34.080001831054688, 15 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 9, 14, 47, 0, 0, DateTimeKind.Unspecified), 3, 32.020000457763672, 21 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 9, 4, 38, 0, 0, DateTimeKind.Unspecified), 1, 36.810001373291016, 43 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 30, 0, 0, DateTimeKind.Unspecified), 20.389999389648438, 23 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 1, 23.680000305175781, 5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 19, 12, 23, 0, 0, DateTimeKind.Unspecified), 28.75, 36 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 4, 15, 15, 0, 0, DateTimeKind.Unspecified), 11.350000381469727, 3 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 17, 11, 11, 0, 0, DateTimeKind.Unspecified), 4, 44.240001678466797, 47 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 21, 22, 25, 0, 0, DateTimeKind.Unspecified), 1, 29.819999694824219, 18 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 2, 6, 55, 0, 0, DateTimeKind.Unspecified), 34.130001068115234, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 4, 21, 46, 0, 0, DateTimeKind.Unspecified), 4, 26.239999771118164, 10 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 18, 5, 21, 0, 0, DateTimeKind.Unspecified), 17.319999694824219, 4 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 15, 8, 40, 0, 0, DateTimeKind.Unspecified), 2, 43.009998321533203, 27 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 4, 1, 18, 0, 0, DateTimeKind.Unspecified), 3, 32.599998474121094, 21 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 2, 18.959999084472656, 19 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 26, 19, 54, 0, 0, DateTimeKind.Unspecified), 2, 48.599998474121094, 43 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 5, 13, 19, 0, 0, DateTimeKind.Unspecified), 4, 43.310001373291016, 31 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 8, 6, 52, 0, 0, DateTimeKind.Unspecified), 2, 2.369999885559082, 38 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 20, 22, 34, 0, 0, DateTimeKind.Unspecified), 2, 37.669998168945312, 27 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 23, 3, 5, 0, 0, DateTimeKind.Unspecified), 3, 28.0, 49 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 3, 14.630000114440918, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 30, 8, 18, 0, 0, DateTimeKind.Unspecified), 3, 35.659999847412109, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 24, 20, 44, 0, 0, DateTimeKind.Unspecified), 20.430000305175781, 37 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 14, 18, 21, 0, 0, DateTimeKind.Unspecified), 37.630001068115234, 24 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 14, 12, 52, 0, 0, DateTimeKind.Unspecified), 1, 19.700000762939453, 43 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), 35.490001678466797, 20 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 8, 6, 2, 0, 0, DateTimeKind.Unspecified), 13.210000038146973, 28 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 14, 12, 26, 0, 0, DateTimeKind.Unspecified), 3.0999999046325684, 18 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 30, 7, 13, 0, 0, DateTimeKind.Unspecified), 48.490001678466797, 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 2, 20, 55, 0, 0, DateTimeKind.Unspecified), 33.979999542236328, 39 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 8, 4, 37, 0, 0, DateTimeKind.Unspecified), 4, 19.649999618530273, 9 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, 31.030000686645508, 29 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 15, 11, 42, 0, 0, DateTimeKind.Unspecified), 3, 10.619999885559082, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 6, 0, 0, DateTimeKind.Unspecified), 3, 7.9499998092651367, 10 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 21, 1, 44, 0, 0, DateTimeKind.Unspecified), 2, 12.430000305175781, 32 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 21, 23, 32, 0, 0, DateTimeKind.Unspecified), 2, 6.9499998092651367, 45 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 53, 0, 0, DateTimeKind.Unspecified), 2, 4.3899998664855957, 37 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 5, 15, 8, 0, 0, DateTimeKind.Unspecified), 2, 30.139999389648438, 13 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 15, 21, 55, 0, 0, DateTimeKind.Unspecified), 46.659999847412109, 33 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 18, 10, 11, 0, 0, DateTimeKind.Unspecified), 1, 16.809999465942383, 43 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 9, 16, 35, 0, 0, DateTimeKind.Unspecified), 2, 31.440000534057617, 39 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 20, 4, 10, 0, 0, DateTimeKind.Unspecified), 1, 9.5, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 25, 20, 28, 0, 0, DateTimeKind.Unspecified), 1, 15.229999542236328, 5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 29, 18, 48, 0, 0, DateTimeKind.Unspecified), 2, 17.290000915527344, 6 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 27, 1, 12, 0, 0, DateTimeKind.Unspecified), 1, 37.869998931884766, 26 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 15, 1, 25, 0, 0, DateTimeKind.Unspecified), 1, 14.329999923706055, 25 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 2, 4, 7, 0, 0, DateTimeKind.Unspecified), 2, 18.530000686645508, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 23, 3, 23, 0, 0, DateTimeKind.Unspecified), 2, 15.149999618530273, 24 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 1, 11, 40, 0, 0, DateTimeKind.Unspecified), 4, 28.409999847412109, 43 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 4, 23, 18, 0, 0, DateTimeKind.Unspecified), 4, 9.4799995422363281, 7 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 4, 25, 6, 43, 0, 0, DateTimeKind.Unspecified), 2, 9.7299995422363281, 47 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 21, 6, 24, 0, 0, DateTimeKind.Unspecified), 4, 3.0099999904632568, 3 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 22, 14, 16, 0, 0, DateTimeKind.Unspecified), 28.219999313354492, 16 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 3, 4, 45, 0, 0, DateTimeKind.Unspecified), 2, 15.630000114440918, 47 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 24, 13, 27, 0, 0, DateTimeKind.Unspecified), 4, 47.729999542236328, 4 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 9, 6, 14, 0, 0, DateTimeKind.Unspecified), 1, 28.739999771118164, 36 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 2, 0, 0, DateTimeKind.Unspecified), 3, 38.669998168945312, 34 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 23, 10, 16, 0, 0, DateTimeKind.Unspecified), 21.440000534057617, 14 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 23, 22, 38, 0, 0, DateTimeKind.Unspecified), 37.950000762939453, 4 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 29, 18, 29, 0, 0, DateTimeKind.Unspecified), 19.129999160766602, 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 12, 6, 20, 0, 0, DateTimeKind.Unspecified), 24.299999237060547, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 19, 2, 48, 0, 0, DateTimeKind.Unspecified), 42.029998779296875, 7 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 19, 3, 57, 0, 0, DateTimeKind.Unspecified), 2, 24.559999465942383, 36 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 23, 1, 30, 0, 0, DateTimeKind.Unspecified), 21.489999771118164, 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 25, 2, 17, 0, 0, DateTimeKind.Unspecified), 2, 1.809999942779541, 31 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 24, 10, 16, 0, 0, DateTimeKind.Unspecified), 1, 16.129999160766602, 11 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 6, 17, 38, 0, 0, DateTimeKind.Unspecified), 47.060001373291016, 35 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 12, 7, 34, 0, 0, DateTimeKind.Unspecified), 3, 28.389999389648438, 46 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 15, 23, 34, 0, 0, DateTimeKind.Unspecified), 36.709999084472656, 9 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 13, 8, 37, 0, 0, DateTimeKind.Unspecified), 4, 41.650001525878906, 16 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 4, 6, 1, 0, 0, DateTimeKind.Unspecified), 3, 26.760000228881836, 23 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 29, 22, 10, 0, 0, DateTimeKind.Unspecified), 2, 36.819999694824219, 42 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 24, 8, 57, 0, 0, DateTimeKind.Unspecified), 46.639999389648438, 27 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 8, 5, 12, 22, 0, 0, DateTimeKind.Unspecified), 26.620000839233398, 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 11, 10, 29, 0, 0, DateTimeKind.Unspecified), 3, 4.809999942779541, 7 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 13, 6, 52, 0, 0, DateTimeKind.Unspecified), 16.799999237060547, 19 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Measure", "Price" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 4, 31.909999847412109 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 24, 1, 55, 0, 0, DateTimeKind.Unspecified), 2, 16.75, 31 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 16, 17, 8, 0, 0, DateTimeKind.Unspecified), 4, 25.879999160766602, 43 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 11, 28, 11, 27, 0, 0, DateTimeKind.Unspecified), 1, 33.360000610351562, 20 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 20, 15, 52, 0, 0, DateTimeKind.Unspecified), 3, 11.449999809265137, 20 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 16, 2, 38, 0, 0, DateTimeKind.Unspecified), 1, 42.369998931884766, 15 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 16, 0, 46, 0, 0, DateTimeKind.Unspecified), 1, 34.830001831054688, 9 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 23, 7, 55, 0, 0, DateTimeKind.Unspecified), 4, 26.520000457763672, 21 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 10, 14, 11, 0, 0, DateTimeKind.Unspecified), 20.389999389648438, 12 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 1, 18, 22, 13, 0, 0, DateTimeKind.Unspecified), 1, 6.1500000953674316, 47 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Measure", "Price" },
                values: new object[] { new DateTime(2021, 2, 20, 21, 13, 0, 0, DateTimeKind.Unspecified), 4, 2.2000000476837158 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 9, 10, 6, 57, 0, 0, DateTimeKind.Unspecified), 4, 38.459999084472656, 34 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 6, 10, 11, 38, 0, 0, DateTimeKind.Unspecified), 3, 22.0, 28 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 12, 19, 29, 0, 0, DateTimeKind.Unspecified), 20.450000762939453, 12 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 3, 6, 5, 29, 0, 0, DateTimeKind.Unspecified), 2, 31.620000839233398, 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 1, 3, 36, 0, 0, DateTimeKind.Unspecified), 3, 28.600000381469727, 41 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Measure", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 7, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, 23.129999160766602, 9 });

            migrationBuilder.UpdateData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 13, 41 },
                column: "Measure",
                value: 4);

            migrationBuilder.UpdateData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 3, 45 },
                columns: new[] { "Measure", "Quantity" },
                values: new object[] { 4, 44 });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Quantity" },
                values: new object[,]
                {
                    { 70, 4, 4, 1 },
                    { 63, 34, 2, 4 },
                    { 87, 62, 1, 46 },
                    { 24, 33, 3, 2 },
                    { 30, 47, 2, 18 },
                    { 34, 6, 3, 41 },
                    { 65, 6, 2, 16 },
                    { 18, 5, 4, 34 },
                    { 40, 94, 1, 20 },
                    { 1, 38, 4, 41 },
                    { 5, 35, 1, 30 },
                    { 99, 10, 1, 36 },
                    { 84, 66, 3, 2 },
                    { 56, 63, 3, 22 },
                    { 28, 37, 4, 7 },
                    { 22, 31, 2, 49 },
                    { 78, 24, 4, 30 },
                    { 56, 62, 3, 14 },
                    { 67, 33, 3, 23 },
                    { 71, 17, 1, 27 },
                    { 52, 17, 2, 42 },
                    { 83, 91, 2, 20 },
                    { 19, 50, 2, 34 },
                    { 17, 49, 1, 30 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Quantity" },
                values: new object[,]
                {
                    { 69, 70, 4, 15 },
                    { 18, 4, 3, 23 },
                    { 11, 89, 4, 45 },
                    { 76, 19, 4, 43 },
                    { 85, 57, 1, 24 },
                    { 8, 57, 3, 6 },
                    { 30, 36, 1, 8 },
                    { 6, 36, 4, 48 },
                    { 8, 77, 3, 19 },
                    { 85, 91, 3, 10 },
                    { 94, 16, 4, 45 },
                    { 65, 31, 4, 45 },
                    { 42, 60, 1, 26 },
                    { 10, 74, 4, 28 },
                    { 28, 13, 2, 5 },
                    { 52, 22, 3, 41 },
                    { 15, 99, 2, 6 },
                    { 50, 64, 4, 48 },
                    { 5, 30, 4, 38 },
                    { 29, 6, 1, 6 },
                    { 57, 18, 2, 14 },
                    { 27, 81, 4, 14 },
                    { 11, 65, 3, 30 },
                    { 38, 22, 3, 2 },
                    { 85, 15, 3, 13 },
                    { 61, 21, 3, 23 },
                    { 62, 93, 2, 13 },
                    { 1, 76, 2, 34 },
                    { 45, 9, 3, 29 },
                    { 54, 34, 4, 6 },
                    { 4, 69, 4, 19 },
                    { 74, 5, 1, 42 },
                    { 35, 81, 1, 25 },
                    { 11, 56, 1, 43 },
                    { 94, 42, 1, 8 },
                    { 87, 24, 1, 21 },
                    { 90, 77, 2, 24 },
                    { 5, 87, 2, 36 },
                    { 59, 4, 3, 17 },
                    { 66, 21, 1, 26 },
                    { 37, 74, 2, 46 },
                    { 25, 69, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Quantity" },
                values: new object[,]
                {
                    { 29, 40, 2, 43 },
                    { 16, 23, 4, 17 },
                    { 44, 77, 4, 11 },
                    { 93, 67, 1, 7 },
                    { 29, 53, 3, 12 },
                    { 64, 89, 4, 42 },
                    { 56, 53, 4, 28 },
                    { 80, 89, 4, 26 },
                    { 54, 38, 2, 3 },
                    { 77, 61, 4, 35 },
                    { 32, 48, 1, 21 },
                    { 57, 93, 2, 21 },
                    { 10, 79, 2, 30 },
                    { 6, 93, 3, 12 },
                    { 88, 23, 3, 20 },
                    { 88, 91, 3, 13 },
                    { 81, 32, 4, 28 },
                    { 84, 20, 3, 1 },
                    { 80, 67, 2, 3 },
                    { 36, 9, 2, 21 },
                    { 35, 43, 1, 36 },
                    { 31, 33, 1, 18 },
                    { 87, 30, 4, 15 },
                    { 73, 22, 2, 43 },
                    { 16, 29, 4, 25 },
                    { 92, 53, 1, 36 },
                    { 56, 78, 1, 32 },
                    { 25, 5, 2, 10 },
                    { 57, 36, 2, 28 },
                    { 48, 2, 1, 40 },
                    { 43, 82, 4, 49 },
                    { 13, 26, 4, 14 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 18, 10, 32, 0, 0, DateTimeKind.Unspecified), 91.354699910783538 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 6, 7, 16, 0, 0, DateTimeKind.Unspecified), 48.365437734576609 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 22, 8, 10, 0, 0, DateTimeKind.Unspecified), 13.335776352945611 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 13, 0, 0, DateTimeKind.Unspecified), 44.136661789909311 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 29, 1, 42, 0, 0, DateTimeKind.Unspecified), 94.840987800546444 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 12, 20, 25, 0, 0, DateTimeKind.Unspecified), 19.178624413525046 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 27, 3, 21, 0, 0, DateTimeKind.Unspecified), 61.90069911484639 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 4, 8, 28, 0, 0, DateTimeKind.Unspecified), 98.080027374476202 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 13, 15, 15, 0, 0, DateTimeKind.Unspecified), 37.167643779035494 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 11, 14, 47, 0, 0, DateTimeKind.Unspecified), 5.6710377450431873 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 21, 3, 39, 0, 0, DateTimeKind.Unspecified), 8.7982154240823416 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 26, 2, 5, 0, 0, DateTimeKind.Unspecified), 59.542609568472301 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 7, 6, 55, 0, 0, DateTimeKind.Unspecified), 64.655829248789615 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 26, 1, 49, 0, 0, DateTimeKind.Unspecified), 84.305286402024933 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 18, 7, 5, 0, 0, DateTimeKind.Unspecified), 77.383524986162556 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 21, 18, 50, 0, 0, DateTimeKind.Unspecified), 18.54356651825065 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 6, 18, 20, 0, 0, DateTimeKind.Unspecified), 64.128593240458798 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 4, 7, 22, 0, 0, DateTimeKind.Unspecified), 26.096521348737422 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 1, 13, 31, 0, 0, DateTimeKind.Unspecified), 13.05293365756652 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 27, 1, 3, 0, 0, DateTimeKind.Unspecified), 75.447599039621466 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 25, 14, 27, 0, 0, DateTimeKind.Unspecified), 94.943586084499756 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 22, 3, 21, 0, 0, DateTimeKind.Unspecified), 23.850602779933531 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 8, 7, 55, 0, 0, DateTimeKind.Unspecified), 24.492876612810825 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 1, 9, 2, 0, 0, DateTimeKind.Unspecified), 98.294540047782718 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 18, 2, 39, 0, 0, DateTimeKind.Unspecified), 48.545544975691264 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 4, 0, 0, DateTimeKind.Unspecified), 75.398806845954994 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 21, 5, 1, 0, 0, DateTimeKind.Unspecified), 75.852179812198585 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 19, 2, 30, 0, 0, DateTimeKind.Unspecified), 51.116605929618984 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 3, 10, 20, 0, 0, DateTimeKind.Unspecified), 76.93242865704579 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 13, 14, 20, 0, 0, DateTimeKind.Unspecified), 73.474133204423879 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 30, 4, 30, 0, 0, DateTimeKind.Unspecified), 49.13005834451414 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 20, 10, 3, 0, 0, DateTimeKind.Unspecified), 36.557912417947271 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 26, 3, 35, 0, 0, DateTimeKind.Unspecified), 66.643626334911033 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 54.485091389848428 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 10, 9, 50, 0, 0, DateTimeKind.Unspecified), 64.886062152630672 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 4, 11, 46, 0, 0, DateTimeKind.Unspecified), 94.31299213148327 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 24, 21, 42, 0, 0, DateTimeKind.Unspecified), 42.600202772580182 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 2, 7, 24, 0, 0, DateTimeKind.Unspecified), 72.134463876082776 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 27, 4, 58, 0, 0, DateTimeKind.Unspecified), 57.741793208635315 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 12, 10, 18, 0, 0, DateTimeKind.Unspecified), 31.143799161605443 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 34, 0, 0, DateTimeKind.Unspecified), 67.550849428656903 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 4, 21, 6, 0, 0, DateTimeKind.Unspecified), 83.229469242612581 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 4, 7, 42, 0, 0, DateTimeKind.Unspecified), 63.780231350464852 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 30, 23, 6, 0, 0, DateTimeKind.Unspecified), 78.788167447684415 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 26, 22, 18, 0, 0, DateTimeKind.Unspecified), 62.142277133717329 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 2, 18, 21, 0, 0, DateTimeKind.Unspecified), 34.198311225137822 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 5, 9, 38, 0, 0, DateTimeKind.Unspecified), 33.275212770456079 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 18, 12, 2, 0, 0, DateTimeKind.Unspecified), 95.817787515845978 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 11, 8, 35, 0, 0, DateTimeKind.Unspecified), 58.668437583683264 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 9, 9, 59, 0, 0, DateTimeKind.Unspecified), 19.595327120551527 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 3, 18, 46, 0, 0, DateTimeKind.Unspecified), 95.500067433575197 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 4, 2, 54, 0, 0, DateTimeKind.Unspecified), 65.589377506444876 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 22, 17, 45, 0, 0, DateTimeKind.Unspecified), 60.443777543233601 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 30, 13, 15, 0, 0, DateTimeKind.Unspecified), 98.156392130607927 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 58, 0, 0, DateTimeKind.Unspecified), 13.37095383618537 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 7, 10, 0, 0, DateTimeKind.Unspecified), 54.02051071357937 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 29, 23, 20, 0, 0, DateTimeKind.Unspecified), 63.584962798554898 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 21, 23, 7, 0, 0, DateTimeKind.Unspecified), 80.939537447849077 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 19, 23, 33, 0, 0, DateTimeKind.Unspecified), 30.132178328992882 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 19, 13, 37, 0, 0, DateTimeKind.Unspecified), 93.881718253661745 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 24, 0, 0, DateTimeKind.Unspecified), 85.750109705957641 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 9, 0, 50, 0, 0, DateTimeKind.Unspecified), 86.499538917792748 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 29, 22, 7, 0, 0, DateTimeKind.Unspecified), 55.750976267154783 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 29, 0, 55, 0, 0, DateTimeKind.Unspecified), 98.14308503369945 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 15, 10, 17, 0, 0, DateTimeKind.Unspecified), 64.905404368837083 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 55.903427838768543 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 3, 31, 22, 30, 0, 0, DateTimeKind.Unspecified), 55.708328992458213 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 1, 14, 25, 0, 0, DateTimeKind.Unspecified), 19.170602991790791 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 19, 15, 59, 0, 0, DateTimeKind.Unspecified), 89.240469236504509 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 13, 19, 18, 0, 0, DateTimeKind.Unspecified), 63.182977768212083 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 25, 21, 8, 0, 0, DateTimeKind.Unspecified), 80.630579484454628 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 5, 10, 55, 0, 0, DateTimeKind.Unspecified), 66.252221692005278 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 6, 2, 24, 0, 0, DateTimeKind.Unspecified), 60.313706712943365 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 18, 3, 12, 0, 0, DateTimeKind.Unspecified), 57.739208898851281 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 21, 22, 28, 0, 0, DateTimeKind.Unspecified), 47.017674715266409 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 19, 17, 20, 0, 0, DateTimeKind.Unspecified), 52.449760183901411 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 20, 19, 39, 0, 0, DateTimeKind.Unspecified), 73.306934922145189 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 8, 8, 49, 0, 0, DateTimeKind.Unspecified), 74.204489753211149 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 3, 10, 44, 0, 0, DateTimeKind.Unspecified), 64.153185078479908 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 16, 8, 18, 0, 0, DateTimeKind.Unspecified), 4.8452812162438788 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 3, 2, 26, 0, 0, DateTimeKind.Unspecified), 46.837424008100022 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), 51.223583558678435 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 5, 17, 54, 0, 0, DateTimeKind.Unspecified), 82.641312668398641 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 1, 26, 0, 21, 0, 0, DateTimeKind.Unspecified), 47.920443551577833 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 10, 19, 33, 0, 0, DateTimeKind.Unspecified), 40.632859787267101 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 1, 36, 0, 0, DateTimeKind.Unspecified), 5.059742365060254 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 8, 26, 16, 17, 0, 0, DateTimeKind.Unspecified), 50.748179338289511 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 19, 0, 0, DateTimeKind.Unspecified), 9.2260752353938642 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 3, 18, 31, 0, 0, DateTimeKind.Unspecified), 10.609694169652506 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 12, 2, 39, 0, 0, DateTimeKind.Unspecified), 90.238138013164573 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 5, 6, 12, 25, 0, 0, DateTimeKind.Unspecified), 18.249611535225814 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 5, 22, 34, 0, 0, DateTimeKind.Unspecified), 67.62531589419828 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 11, 11, 7, 50, 0, 0, DateTimeKind.Unspecified), 39.102765179287069 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 4, 7, 15, 21, 0, 0, DateTimeKind.Unspecified), 17.246205110683203 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 18, 18, 54, 0, 0, DateTimeKind.Unspecified), 96.984709949225518 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 28, 1, 44, 0, 0, DateTimeKind.Unspecified), 53.744940353904354 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 2, 22, 59, 0, 0, DateTimeKind.Unspecified), 21.787930542970045 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 7, 5, 6, 46, 0, 0, DateTimeKind.Unspecified), 73.962298300565365 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 10, 16, 12, 48, 0, 0, DateTimeKind.Unspecified), 12.435595961490458 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 26, 4, 42, 0, 0, DateTimeKind.Unspecified), 43.956223958151519 });

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 18, 3, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 5, 3, 50, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 24, 13, 46, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 2, 0, 12, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 3, 18, 58, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 7, 16, 31, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 3, 14, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 12, 7, 46, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 20, 20, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 6, 3, 49, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 17, 3, 3, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 25, 8, 32, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 27, 21, 26, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 16, 1, 54, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 20, 18, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 12, 6, 35, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 7, 18, 24, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 23, 16, 7, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 4, 17, 7, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 24, 11, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 8, 2, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 27, 3, 42, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 1, 2, 2, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 26, 20, 2, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 15, 11, 18, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 7, 4, 3, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 1, 13, 2, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 25, 10, 41, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 4, 19, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 6, 4, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 10, 3, 8, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 1, 2, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 17, 5, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 7, 5, 32, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 1, 8, 31, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 20, 20, 42, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 12, 6, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 29, 16, 51, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 20, 9, 24, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 14, 2, 12, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 20, 3, 40, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 2, 19, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 10, 22, 49, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 30, 21, 42, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 20, 14, 38, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 14, 5, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 22, 0, 47, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 5, 19, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 19, 12, 41, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 28, 5, 2, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 1, 4, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 11, 13, 22, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 25, 10, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 24, 5, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 11, 0, 48, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 12, 0, 8, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 24, 11, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 8, 4, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 22, 7, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 1, 12, 27, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 3, 1, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 17, 21, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 14, 0, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 2, 23, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 9, 23, 54, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 29, 14, 51, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 2, 52, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 21, 15, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 15, 17, 22, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 2, 21, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 30, 23, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 9, 1, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 2, 6, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 22, 14, 55, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 3, 7, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 3, 7, 16, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 16, 4, 52, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 2, 4, 19, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 4, 5, 23, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 30, 5, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 14, 3, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 29, 17, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 22, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 14, 53, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 1, 3, 1, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 27, 13, 46, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 6, 15, 56, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 22, 0, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 28, 4, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 8, 23, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 27, 8, 58, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 7, 2, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2021, 10, 6, 9, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 19, 20, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 12, 0, 18, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 2, 6, 34, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 17, 18, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 6, 23, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 21, 21, 48, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 49, 42 },
                    { 14, 2 },
                    { 75, 65 },
                    { 49, 7 },
                    { 19, 32 },
                    { 86, 83 },
                    { 95, 99 },
                    { 87, 21 },
                    { 15, 98 },
                    { 90, 27 },
                    { 97, 25 },
                    { 55, 3 },
                    { 13, 65 },
                    { 69, 71 },
                    { 36, 38 },
                    { 67, 80 },
                    { 76, 79 },
                    { 57, 55 },
                    { 87, 56 },
                    { 57, 82 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 22, 52 },
                    { 52, 42 },
                    { 54, 40 },
                    { 3, 36 },
                    { 1, 90 },
                    { 43, 94 },
                    { 11, 81 },
                    { 90, 85 },
                    { 76, 56 },
                    { 32, 91 },
                    { 99, 45 },
                    { 59, 62 },
                    { 96, 48 },
                    { 73, 71 },
                    { 54, 74 },
                    { 28, 80 },
                    { 32, 21 },
                    { 67, 79 },
                    { 70, 8 },
                    { 95, 76 },
                    { 58, 11 },
                    { 48, 1 },
                    { 58, 32 },
                    { 74, 71 },
                    { 19, 70 },
                    { 67, 89 },
                    { 52, 56 },
                    { 40, 86 },
                    { 60, 68 },
                    { 8, 31 },
                    { 72, 45 },
                    { 34, 76 },
                    { 43, 40 },
                    { 71, 62 },
                    { 1, 87 },
                    { 86, 28 },
                    { 93, 8 },
                    { 81, 99 },
                    { 30, 6 },
                    { 29, 60 },
                    { 29, 22 },
                    { 21, 59 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 2, 72 },
                    { 24, 18 },
                    { 10, 94 },
                    { 98, 37 },
                    { 1, 66 },
                    { 70, 91 },
                    { 57, 54 },
                    { 76, 27 },
                    { 12, 96 },
                    { 39, 98 },
                    { 67, 20 },
                    { 45, 95 },
                    { 21, 14 },
                    { 46, 10 },
                    { 1, 13 },
                    { 43, 75 },
                    { 46, 51 },
                    { 52, 49 },
                    { 38, 4 },
                    { 96, 12 },
                    { 16, 38 },
                    { 23, 8 },
                    { 64, 41 },
                    { 11, 31 },
                    { 46, 68 },
                    { 70, 32 },
                    { 51, 56 },
                    { 62, 19 },
                    { 11, 45 },
                    { 31, 38 },
                    { 9, 91 },
                    { 78, 55 },
                    { 13, 2 },
                    { 10, 6 },
                    { 30, 39 },
                    { 14, 53 },
                    { 4, 38 },
                    { 27, 3 }
                });
        }
    }
}
