using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class BycleEntityConfiguration : IEntityTypeConfiguration<BycleEntity>
{
    public void Configure(EntityTypeBuilder<BycleEntity> builder)
    {
        builder.HasMany(x => x.Reviews)
            .WithOne(x => x.Bycle)
            .HasForeignKey(x => x.BycleId);
    }
}
