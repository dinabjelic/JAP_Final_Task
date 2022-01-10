using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipesApp.API.Middleware;
using RecipesApp.API.StartupExtensions;
using RecipesApp.StartupExtensions;

namespace RecipesApp_
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        //public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddApplicationServices(_configuration);
            services.AddIdentiyServices(_configuration);
            services.AddDbContextService(_configuration);
            services.AddLoggerDbContextService(_configuration);
            services.AddCors();
            services.AddAutoMapper(typeof(RecipesApp.Mapper.AutoMapper));


            services.AddControllers();
            services.AddSwaggerService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseMiddleware<ExceptionMiddleware>();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RecipesApp_ v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.MigrationInitialisation();
        }
    }
}
