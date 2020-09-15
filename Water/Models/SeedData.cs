using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Water.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                //context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Small",
                    Description = "12oz",
                    Category = "Personnal",
                    Price = 1.20M
                },
                new Product
                {
                    Name = "Medium",
                    Description = "16oz",
                    Category = "Personnal",
                    Price = 1.99M
                },
                new Product
                {
                    Name = "Large",
                    Description = "24oz",
                    Category = "Personnal",
                    Price = 2.60M
                },
                new Product
                {
                    Name = "Jug",
                    Description = "2.5 Gallon",
                    Category = "Shared",
                    Price = 2.99M
                },
                new Product
                {
                    Name = "Barrel",
                    Description = "5 Gallon",
                    Category = "Family",
                    Price = 5.99M
                },
                new Product
                {
                    Name = "LargeBarrel",
                    Description = "10 Gallon",
                    Category = "Family",
                    Price = 8.99M
                });
                context.SaveChanges();
            }
        }
    }
}

