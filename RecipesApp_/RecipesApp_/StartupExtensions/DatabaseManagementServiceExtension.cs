using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipesApp.Database;
using RecipesApp.LoggerDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.API.StartupExtensions
{
    public static class DatabaseManagementServiceExtension
    {
        // Getting the scope of our database context
        public static void MigrationInitialisation(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                // Takes all of our migrations files and apply them against the database in case they are not implemented
                serviceScope.ServiceProvider.GetService<RecipesDbContext>().Database.Migrate();
                serviceScope.ServiceProvider.GetService<RecipesLoggerDbContext>().Database.Migrate();

            }
        }
    }
}
