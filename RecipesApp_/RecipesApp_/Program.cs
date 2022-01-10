using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog.Sinks.Elasticsearch;
using System.Reflection;
using Serilog.Core;
using Serilog.Exceptions;

namespace RecipesApp_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigureLogging();
            CreateHostBuilder(args).Build().Run();

        }

        //private static void CreateHost(string[] args)
        //{
        //    try
        //    {
        //        CreateHostBuilder(args).Build().Run();
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Log.Fatal($"Failed to start {Assembly.GetExecutingAssembly().GetName().Name}", ex);
        //        throw;
        //    }
        //}

        public static IHostBuilder CreateHostBuilder(string[] args) =>
         Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        })
        .ConfigureAppConfiguration(configuration =>
        {
            configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            configuration.AddJsonFile(
                $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                optional: true);
        })
        .UseSerilog();
        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    var configSettings = new ConfigurationBuilder()
        //                             .AddJsonFile("appsettings.Development.json")
        //                             .Build();
        //    Log.Logger = new LoggerConfiguration()
        //           .ReadFrom.Configuration(configSettings)
        //           .CreateLogger();
        //    return Host.CreateDefaultBuilder(args)
        //        .ConfigureAppConfiguration(config =>
        //        {
        //            config.AddConfiguration(configSettings);
        //        })
        //        .ConfigureLogging(logging =>
        //        {
        //            logging.AddSerilog();
        //        })
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
        //}

        private static void ConfigureLogging()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile(
                    $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                    optional: true)
                .Build();

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .Enrich.WithExceptionDetails()
                .Enrich.WithMachineName()
                .WriteTo.Debug()
                .WriteTo.Console()
                .WriteTo.Elasticsearch(ConfigureElasticSink(configuration, environment))
                .Enrich.WithProperty("Environment", environment)
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        private static ElasticsearchSinkOptions ConfigureElasticSink(IConfigurationRoot configuration, string environment)
        {
            return new ElasticsearchSinkOptions(new Uri(configuration["ElasticConfiguration:Uri"]))
            {
                AutoRegisterTemplate = true,
                IndexFormat = $"{Assembly.GetExecutingAssembly().GetName().Name.ToLower().Replace(".", "-")}-{environment?.ToLower().Replace(".", "-")}-{DateTime.UtcNow:yyyy-MM}"
            };
        }  
    }
}
