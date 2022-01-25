using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipesApp.Database;
using RecipesApp.Interfaces;
using RecipesApp.Services;
using RecipesApp.Services.Interfaces;
using RecipesApp.Services.Services;

namespace RecipesApp.StartupExtensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ICategoryService, Categories>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IGetRecipeService, RecipeProcedureService>();
            services.AddScoped<IIngredientRecipeCostService, IngredientRecipeCostService>();
            services.AddScoped<IReportJobService, ReportJobService>();


            return services;
        }
    }
}
