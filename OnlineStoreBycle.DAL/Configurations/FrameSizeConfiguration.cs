using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class FrameSizeConfiguration : IEntityTypeConfiguration<FrameSizeEntity>
{
    public void Configure(EntityTypeBuilder<FrameSizeEntity> builder)
    {
        builder.HasMany(x => x.Bycles)
            .WithOne(x => x.FrameSize)
            .HasForeignKey(x => x.FrameSizeId);
    }
}
