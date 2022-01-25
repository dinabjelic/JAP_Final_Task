using AutoMapper;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipesApp.API.Middleware;
using RecipesApp.API.StartupExtensions;
using RecipesApp.Services.Interfaces;
using RecipesApp.StartupExtensions;
using System;

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

            services.AddHangfire(config => config
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseDefaultTypeSerializer()
            .UseMemoryStorage());

            services.AddHangfireServer();
            services.AddControllers();
            services.AddSwaggerService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
            IBackgroundJobClient backgroundJobClient, IRecurringJobManager recurringJobManager,
            IServiceProvider serviceProvider)
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

            app.UseHangfireDashboard();
            backgroundJobClient.Enqueue(() => Console.WriteLine("Hello Hangfire job!"));
            recurringJobManager.AddOrUpdate(
                "Run every three hours",
                () => serviceProvider.GetService<IReportJobService>().GetRecipesAsync(),
                "0 0 */3 ? * *"
                );

        }
    }
}
