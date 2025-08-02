using Microsoft.EntityFrameworkCore;
using CozyComfort.Services.Models;
namespace CozyComfort.Services.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Blanket> Blankets { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Blanket)
                .WithMany()
                .HasForeignKey(i => i.BlanketId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Blanket)
                .WithMany()
                .HasForeignKey(o => o.BlanketId);
        }
    }
}
