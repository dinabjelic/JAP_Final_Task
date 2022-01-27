using AutoMapper.Configuration;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RecipesApp.Services.Interfaces;
using System;

namespace RecipesApp.API.StartupExtensions
{
    public static class HangfireExtension
    {
        public static void StartHangifire(this IApplicationBuilder app, IBackgroundJobClient backgroundJobClient,IRecurringJobManager recurringJobManager,
            IServiceProvider serviceProvider)
        {
            backgroundJobClient.Enqueue(() => Console.WriteLine("Hello Hangfire job!"));
            recurringJobManager.AddOrUpdate(
                "Run every three hours",
                () => serviceProvider.GetService<IReportJobService>().GetRecipesAsync(),
                "0 0 */3 ? * *"
                );
        }
    }
}
