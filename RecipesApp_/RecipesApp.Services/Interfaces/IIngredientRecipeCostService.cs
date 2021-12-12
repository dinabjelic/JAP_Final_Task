using RecipesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Services.Interfaces
{
    public interface IIngredientRecipeCostService
    {
        /// <summary>
        /// Returns ingredients cost and recipe sum 
        /// </summary>
        /// <param name="recipeDetails"></param>
        /// <returns></returns>
        double IngredientRecipeCost(GetRecipeDetailsResponse recipeDetails);
    }
}
