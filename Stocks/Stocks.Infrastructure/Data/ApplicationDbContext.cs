using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stocks.Domain.Models;

namespace Stocks.Infrastructre.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Account>()
            //    .HasMany(a => a.AssetTransactions)
            //    .WithOne(at => at.Account)
            //    .HasForeignKey(at => at.AccountId);

            modelBuilder.Entity<Account>().Property(a => a.Balance).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<AssetTransaction>().OwnsOne(at => at.Asset, a =>
            {
                a.Property(a => a.Symbol).HasColumnName("AssetSymbol").HasMaxLength(10).IsRequired(true);
                a.Property(a => a.PricePerShare).HasColumnName("AssetPricePerShare").HasColumnType("decimal(18,2)").IsRequired(true);
            });
        }
    }
}
