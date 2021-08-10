using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    // Make sure you add DbContext service to services so you can inject it
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {}
        public DbSet<Product> Products { get; set; }
    }
}