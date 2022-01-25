using Microsoft.AspNetCore.Mvc;
using RecipesApp.Core.Responses;
using RecipesApp.Database.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesApp.Services.Interfaces
{
    public interface IReportJobService
    {
       
        /// <summary>
        /// Returns all recipes which are available 
        /// </summary>
        /// <returns></returns>
        Task GetRecipesAsync();

    }
}
