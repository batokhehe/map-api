using MAPZebraPrinter.Models;
using Microsoft.EntityFrameworkCore;

namespace MAPZebraPrinter.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<ProductRSF> ProductRSF { get; set; }
        public DbSet<AliasNumber> AliasNumber { get; set; }
        public DbSet<BOEODTrn> BOEODTrn { get; set; }
        public DbSet<SalesPriceList> SalesPriceList { get; set; }
        public DbSet<SystemTable> SystemTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductRSF>().HasNoKey();
            modelBuilder.Entity<AliasNumber>().HasNoKey();
            modelBuilder.Entity<SalesPriceList>().HasNoKey();
            modelBuilder.Entity<SystemTable>().HasNoKey();
            modelBuilder.Entity<BOEODTrn>().HasNoKey();

            // If you want to map to a specific view or table, do this optionally:
            // modelBuilder.Entity<ProductRSF>().ToView("YourViewName");

            base.OnModelCreating(modelBuilder);
        }
    }
}
