using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class BrandBycleConfiguration : IEntityTypeConfiguration<BrandBycleEntity>
{
    public void Configure(EntityTypeBuilder<BrandBycleEntity> builder)
    {
        builder.HasMany(x => x.Bycles)
            .WithOne(x => x.BrandBycle)
            .HasForeignKey(x => x.BrandId);
    }
}