using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Configurations;

internal sealed class PriceConfiguration : IEntityTypeConfiguration<PriceEntity>
{
    public void Configure(EntityTypeBuilder<PriceEntity> builder)
    {
        
    }
}