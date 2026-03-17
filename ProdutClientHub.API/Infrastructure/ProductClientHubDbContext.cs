using Microsoft.EntityFrameworkCore;
using ProdutClientHub.API.Entities;

namespace ProdutClientHub.API.Infrastructure
{
    public class ProductClientHubDbContext : DbContext

    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=productclienthub.sqlite");
        }
    }
}
