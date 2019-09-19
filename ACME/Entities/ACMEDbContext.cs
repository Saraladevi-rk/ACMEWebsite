using Microsoft.EntityFrameworkCore;

namespace ACME.Models
{
    public class ACMEDbContext : DbContext
    {
        public ACMEDbContext(DbContextOptions<ACMEDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .ToTable("Country");

            modelBuilder.Entity<Postcodes>()
                .ToTable("Postcodes");

            modelBuilder.Entity<OfferApplication>()
                .ToTable("OfferApplication");
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Postcodes> Postcodes { get; set; }

        public DbSet<OfferApplication> OfferApplications { get; set; }
    }
}