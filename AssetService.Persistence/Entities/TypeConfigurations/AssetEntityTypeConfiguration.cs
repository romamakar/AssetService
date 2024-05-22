using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetService.Persistence.Entities.TypeConfigurations
{
    public class AssetEntityTypeConfiguration : IEntityTypeConfiguration<AssetEntity>
    {
        public void Configure(EntityTypeBuilder<AssetEntity> builder)
        {
            builder.HasOne(x => x.Client).WithMany(x => x.Assets).HasForeignKey(x => x.ClientId);
            builder.ToTable("asset", "public");
        }
    }
}
