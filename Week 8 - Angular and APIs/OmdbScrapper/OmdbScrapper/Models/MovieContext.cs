using Microsoft.EntityFrameworkCore;

namespace OmdbScrapper.Models
{
    public class MovieContext :DbContext
    {
        //Db set always needs to be public
        public DbSet<MovieDetails> MovieDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=OmdbAPI;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    }
}
