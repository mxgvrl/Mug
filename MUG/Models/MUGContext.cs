using Microsoft.EntityFrameworkCore;

namespace MUG.Models {
    public class MUGContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Additions> Additions { get; set; }
        public DbSet<UserOrder> UserOrder { get; set; }
        public DbSet<OrderComposition> OrderComposition { get; set; }

 
        public MUGContext(DbContextOptions<MUGContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}