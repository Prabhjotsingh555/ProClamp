using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProClamp;
using ProClamp.Data;
using ProClamp.Models;
using System;

namespace MvcMovie
{
    public class Program
    {
        public static void Main(string[] args)  //Starting point of application
        {
            var host = CreateHostBuilder(args).Build(); //make a host for the application by using configuration

            using (var scope = host.Services.CreateScope()) //create a scope for proper resource management
            {
                var services = scope.ServiceProvider; //obtain the scope

                try
                {
                    SeedData.Initialize(services); //Initialize the databasw with seedData
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run(); // run the application

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}