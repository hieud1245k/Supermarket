using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMarket.Core.Models;

namespace SuperMarket.Core
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        internal Task Savechange()
        {
            throw new NotImplementedException();
        }
    }
}