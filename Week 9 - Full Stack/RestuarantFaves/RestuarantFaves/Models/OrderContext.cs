using Microsoft.EntityFrameworkCore;

namespace RestuarantFaves.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Orders;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

    }
}
