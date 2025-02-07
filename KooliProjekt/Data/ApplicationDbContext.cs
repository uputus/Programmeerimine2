using KooliProjekt.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // DbSet mudelid, mis vastavad teie andmebaasi tabelitele
        public DbSet<InvestmentClass> InvestmentClasses { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Investment> Investments { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        // Konstruktor, mis võimaldab andmebaasi ühenduse seadeid
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Kui soovite lisada täiendavaid seoseid või konfigureerimist, saate seda teha siin
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Asset>()
                .HasKey(a => a.AssetID);

            modelBuilder.Entity<Transaction>()
                .HasKey(t => t.TransactionID);

            // Define other relationships and configurations
        }
    }
}

