using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMarket.Core.Models;

namespace SuperMarket.Core.Helpers
{
    public static class Seed
    {
        public static async Task SeedCategoryAsync(DataContext context)
        {
            if (await context.Categories.AnyAsync())
            {
                return;
            }
            await context.Categories.AddAsync(new Category { Name = "Phone" });
            await context.Categories.AddAsync(new Category { Name = "Tivi" });
            
            await context.SaveChangesAsync();
        }
        public static async Task SeedProducts(DataContext context) 
        {
            if(await context.Products.AnyAsync()) {
                return;
            }
            await context.Products.AddAsync(new Product{
                Name = "IPhone 11",
                CategoryId = 1,
                Description = "Description",
                Price = 250,
                ImageUrl = "This a a Image"
            });
            await context.SaveChangesAsync();
        }
    }
}