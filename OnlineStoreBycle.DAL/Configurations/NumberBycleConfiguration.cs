using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class NumberBycleConfiguration : IEntityTypeConfiguration<NumberBycleEntity>
{
    public void Configure(EntityTypeBuilder<NumberBycleEntity> builder)
    {
        builder.HasMany(x => x.OrderBycles)
            .WithOne(x => x.NumberBycle)
            .HasForeignKey(x => x.NumberBycleId);
    }
}