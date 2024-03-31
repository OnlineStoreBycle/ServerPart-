using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class OrderBycleConfiguration : IEntityTypeConfiguration<OrderBycleEntity>
{
    public void Configure(EntityTypeBuilder<OrderBycleEntity> builder)
    {

    }
}