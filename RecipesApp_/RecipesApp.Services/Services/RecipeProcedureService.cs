using AutoMapper.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Core.Models;
using RecipesApp.Core.Models.Procedures;
using RecipesApp.Database;
using RecipesApp.Services.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Services.Services
{
    public class RecipeProcedureService : IGetRecipeService
    {
        private readonly RecipesDbContext _recipesDbContext;
        private readonly DbConnection _dbConnection;
        public RecipeProcedureService(RecipesDbContext recipesDbContext)
        {
            _recipesDbContext = recipesDbContext;
            _dbConnection = _recipesDbContext.Database.GetDbConnection();
        }

        public async Task<IEnumerable<GetRecipesModel>> GetRecipesAsync()
        {
            return await _dbConnection.QueryAsync<GetRecipesModel>("GetRecipes", commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<GetAllRecipesModel>> GetAllRecipesAsync()
        {
            return await _dbConnection.QueryAsync<GetAllRecipesModel>("GetAllRecipes", commandType: CommandType.StoredProcedure);
        }
    }
}
