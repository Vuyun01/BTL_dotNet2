using BTL_dotnet2.Models;
using Microsoft.EntityFrameworkCore;

namespace BTL_dotnet2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductType { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }




    }
}
