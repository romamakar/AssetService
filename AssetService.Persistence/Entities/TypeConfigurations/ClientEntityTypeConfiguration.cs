using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetService.Persistence.Entities.TypeConfigurations
{
    public class ClientEntityTypeConfiguration : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            
            builder.ToTable("client", "public");
        }
    }
}
