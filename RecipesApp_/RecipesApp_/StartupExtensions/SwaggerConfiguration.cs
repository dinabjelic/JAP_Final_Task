using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.API.StartupExtensions
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RecipesApp_", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",

                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                { { new OpenApiSecurityScheme { Reference= new OpenApiReference{
                    Type= ReferenceType.SecurityScheme,
                    Id="Bearer"
                },
                In=ParameterLocation.Header,
                Name="Bearer", 
                Scheme="Oauth2"
                }, new List<string>() } });

            });

            return services;
        }
    }
}
