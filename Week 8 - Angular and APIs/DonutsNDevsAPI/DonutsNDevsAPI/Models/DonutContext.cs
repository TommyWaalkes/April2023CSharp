using Microsoft.EntityFrameworkCore;

namespace DonutsNDevsAPI.Models
{
    public class DonutContext :DbContext
    {
        public DbSet<Result> donutResults { get; set; }
        public DbSet<DonutDetails> donutDetails { get; set; }
        public DbSet<Extra> extra { get; set; }
        public DbSet<DonutExtras> donutDetailsExtra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Donuts;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    }
}
