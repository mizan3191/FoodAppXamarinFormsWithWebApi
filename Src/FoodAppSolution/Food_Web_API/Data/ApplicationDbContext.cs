using Food_Web_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_Web_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails>  OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Caregory> Caregories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
