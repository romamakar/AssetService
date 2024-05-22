using AssetService.Persistence.Entities;
using AssetService.Persistence.Entities.TypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace AssetService.Persistence
{
    public class AssetDbContext : DbContext
    {
        public AssetDbContext()
        {
        }

        public AssetDbContext(DbContextOptions<AssetDbContext> options) : base(options)
        {
        }
        public DbSet<AssetEntity> Assets { get; set; }
        public DbSet<ClientEntity> Clients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            new AssetEntityTypeConfiguration().Configure(modelBuilder.Entity<AssetEntity>());
            new ClientEntityTypeConfiguration().Configure(modelBuilder.Entity<ClientEntity>());
        }
    }
}
