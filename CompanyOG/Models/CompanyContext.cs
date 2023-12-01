using Microsoft.EntityFrameworkCore;

namespace CompanyOG.Models
{
    public class CompanyContext : DbContext
    {
        //ctor
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
            
        }
        //prop
        public DbSet<CountryRegion> CountryRegions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // c=> c.Code zamiast "Code" ulatwienie
            modelBuilder.Entity<CountryRegion>().HasKey(c => c.Code);
            modelBuilder
                .Entity<CountryRegion>()
                .Property(c=>c.Code)
                .HasColumnName("CountryRegionCode");
            modelBuilder
                .Entity<CountryRegion>()
                .Property(c => c.Date)
                .HasColumnName("ModifiedDate");
            modelBuilder.Entity<CountryRegion>().ToTable("CountryRegion", "Person");

        }

    }
}
