using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreBycle.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreBycle.DAL.Configurations
{
    internal sealed class BycleEntityConfiguration : IEntityTypeConfiguration<BycleEntity>
    {
        public void Configure(EntityTypeBuilder<BycleEntity> builder)
        {
            builder.HasMany(x => x.Reviews)
                .WithOne(x => x.Bycle)
                .HasForeignKey(x => x.BycleId);
        }
    }
}
