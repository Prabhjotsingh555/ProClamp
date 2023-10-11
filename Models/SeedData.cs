using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProClamp.Data;
using System;
using System.Linq;

namespace ProClamp.Models
{
    public static class SeedData
    {
        // Starting the ProClampContext database by using the provided IServiceProvider.
        // When an application first launches, this method is applied to setup and seed the database context.
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ProClampContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProClampContext>>());
            // Looking for any Clamp.
            if (context.Clamp.Any())
            {
                return;   // DB has been seeded
            }

            context.Clamp.AddRange(
                new Clamp
                {
                    Name = "Bessey Clamp",   // First product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Bar",
                    Material = "Steel",
                    WeightInLB = 2.3M,
                    Price = 1600M,
                    JawOpeningInInches = 36M,
                    Application = "Wood"
                },
                new Clamp  
                {
                    Name = "Jorgensen",   // Second product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Hold-Down",
                    Material = "Steel",
                    WeightInLB = 3.1M,
                    Price = 31.75M,
                    JawOpeningInInches = 48M,
                    Application = "Metal"
                },
                new Clamp
                {
                    Name = "Irwin",   // Third product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Quick-Grip",
                    Material = "Cast-Iron",
                    WeightInLB = 3.5M,
                    Price = 18.50M,
                    JawOpeningInInches = 72M,
                    Application = "Metal"
                },
                new Clamp
                {
                    Name = "Pony",   // Fourth product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Pipe",
                    Material = "Steel",
                    WeightInLB = 2.0M,
                    Price = 19.99M,
                    JawOpeningInInches = 5.0M,
                    Application = "Example Application 1"
                },
                new Clamp
                {
                    Name = "Dewalt",   // Fifth product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Pipe",
                    Material = "Steel",
                    WeightInLB = 1.8M,
                    Price = 27.20M,
                    JawOpeningInInches = 60M,
                    Application = "Woods"
                },
                new Clamp
                {
                    Name = "Kreg",   // Sixth product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Trigger",
                    Material = "Steel",
                    WeightInLB = 2.7M,
                    Price = 22.90M,
                    JawOpeningInInches = 36M,
                    Application = "Wood"
                },
                new Clamp
                {
                    Name = "Bora",   // Seventh product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Parallel",
                    Material = "Plastic",
                    WeightInLB = 2.5M,
                    Price = 29.45M,
                    JawOpeningInInches = 84M,
                    Application = "Metal"
                },
                new Clamp
                {
                    Name = "Tekton",   // Eighth product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Spring",
                    Material = "Aluminum",
                    WeightInLB = 3.5M,
                    Price = 35.60M,
                    JawOpeningInInches = 92M,
                    Application = "Metal"
                },
                new Clamp
                {
                    Name = "Hose",   // Ninth product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Hose",
                    Material = "Metal",
                    WeightInLB = 0.2M,
                    Price = 1.99M,
                    JawOpeningInInches = 26M,
                    Application = "Metal"
                },
                new Clamp
                {
                    Name = "Fluke",   // Tenth product and it's information
                    Date = DateTime.Parse("2023-10-09"),
                    Type = "Clamp Meters",
                    Material = "Plastic",
                    WeightInLB = 2.2M,
                    Price = 29.99M,
                    JawOpeningInInches = 36M,
                    Application = "Industrial"
                }
            );
            context.SaveChanges(); //save the change in the database context
        }
    }
}