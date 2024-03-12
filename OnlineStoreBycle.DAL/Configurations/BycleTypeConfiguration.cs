using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class BycleTypeConfiguration : IEntityTypeConfiguration<BycleTypeEntity>
{
    public void Configure(EntityTypeBuilder<BycleTypeEntity> builder)
    {
        builder.HasMany(x => x.Bycles)
            .WithOne(x => x.BycleType)
            .HasForeignKey(x => x.TypeId);

        //builder.HasData(
        //    new() { Id = 1, TypeName = "M" },
        //    new() { Id = 2, TypeName = "E" },
        //    new() { Id = 3, TypeName = "W" }
        //);
    }
}