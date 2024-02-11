using Microsoft.EntityFrameworkCore;
using Sklep.Pages;

namespace Sklep.Context
{
    //aby połaczyć ApplicationDBContext z DbContext trzeba zaistalowac Microsoft EntityFrameWorkCore
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ) 
            : base ( options )
        {
            
        }
        public DbSet<Shared.Products> Products { get; set; }
        public DbSet<Shared.Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shared.Products>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
