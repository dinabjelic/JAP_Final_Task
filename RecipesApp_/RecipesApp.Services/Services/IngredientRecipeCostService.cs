using RecipesApp.Common.Enums;
using RecipesApp.Models;
using RecipesApp.Services.Interfaces;
using System;

namespace RecipesApp.Services.Services
{
    public class IngredientRecipeCostService: IIngredientRecipeCostService
    {
        public double IngredientRecipeCost(GetRecipeDetailsResponse recipeDetails)
        {
            double sum = 0;
            double IngredientQuantiy = 0;
            foreach (var b in recipeDetails.IngredientRecipes)
            {
                var Quantity = b.Quantity;
                var Price = b.Ingredients.Price;
                if (b.Measure == UnitMeasureType.kg || b.Measure == UnitMeasureType.l)
                {
                    IngredientQuantiy = b.Ingredients.Quantity * 1000;
                }
                else
                {
                    IngredientQuantiy = b.Ingredients.Quantity;
                }

                b.IngredientPrice = Math.Round((Quantity * Price) / IngredientQuantiy,4);
                sum += b.IngredientPrice;
                b.TotalCost += sum;
            }
            return Math.Round(sum,4);
        }
    }
}
