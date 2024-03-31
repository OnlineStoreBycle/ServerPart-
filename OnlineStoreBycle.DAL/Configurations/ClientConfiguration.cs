using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class ClientConfiguration : IEntityTypeConfiguration<ClientEntity>
{
    public void Configure(EntityTypeBuilder<ClientEntity> builder)
    {
        builder.HasMany(x => x.Orders)
            .WithOne(x => x.Client)
            .HasForeignKey(x => x.ClientId);
    }
}