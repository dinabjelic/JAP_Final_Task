using RecipesApp.Core.Models;
using RecipesApp.Core.Models.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Services.Interfaces
{
    public interface IGetRecipeService
    {
        /// <summary>
        /// Procedure that retrieves recipes based on a written query
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<GetRecipesModel>> GetRecipesAsync();
        /// <summary>
        /// Procedure that retrieves recipes based on a written query
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<GetAllRecipesModel>> GetAllRecipesAsync();

    }
}
