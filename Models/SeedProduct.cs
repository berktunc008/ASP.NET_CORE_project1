using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webodevberk.Data;

namespace webodevberk.Models
{
    public class SeedProduct
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scope=app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if(!context.Products.Any())
                {
                    context.Products.AddRange(

                       new Product() { Name = "ASUS1", Description = "Core i7", Category = "computer", Price = 5500 },
                        new Product() { Name = "ASUS2", Description = "Core i5", Category = "computer", Price = 1500 },
                        new Product() { Name = "ASUS3", Description = "Core i7", Category = "computer", Price = 2500 },
                        new Product() { Name = "ASUS4", Description = "Core i7", Category = "computer", Price = 3500 }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
