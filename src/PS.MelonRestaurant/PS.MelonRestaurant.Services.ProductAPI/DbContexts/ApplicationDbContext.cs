using Microsoft.EntityFrameworkCore;
using PS.MelonRestaurant.Services.ProductAPI.Models;

namespace PS.MelonRestaurant.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
    }
}
