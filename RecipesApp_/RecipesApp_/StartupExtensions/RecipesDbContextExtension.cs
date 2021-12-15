using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipesApp.Database;
using RecipesApp.LoggerDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.StartupExtensions
{
    public static class RecipesDbContextExtension
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RecipesDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
