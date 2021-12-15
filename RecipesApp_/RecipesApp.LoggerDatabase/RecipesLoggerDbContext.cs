using Microsoft.EntityFrameworkCore;
using RecipesApp.Core.Entities.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.LoggerDatabase
{
    public class RecipesLoggerDbContext : DbContext
    {
        public RecipesLoggerDbContext(DbContextOptions<RecipesLoggerDbContext> options)
         : base(options)
        {
        }

        public DbSet<Logs> Logs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
