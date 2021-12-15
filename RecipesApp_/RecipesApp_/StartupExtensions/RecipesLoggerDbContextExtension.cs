using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipesApp.LoggerDatabase;

namespace RecipesApp.API.StartupExtensions
{
    public static class RecipesLoggerDbContextExtension
    {
        public static IServiceCollection AddLoggerDbContextService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RecipesLoggerDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("LoggerConnection")));

            return services;
        }
    }
}
