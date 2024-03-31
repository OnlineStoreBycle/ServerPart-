using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class StatusConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.HasMany(x => x.Orders)
            .WithOne(x => x.Status)
            .HasForeignKey(x => x.StatusId);
    }
}