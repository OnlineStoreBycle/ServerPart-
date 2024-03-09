using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.DAL.Configurations;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Context;

internal sealed class OnlineStoreBycleDbContext : DbContext
{
    public OnlineStoreBycleDbContext(DbContextOptions<OnlineStoreBycleDbContext> options) : base(options)
    {
        
    }

    public DbSet<BycleTypeEntity> BycleTypeEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BycleTypeConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
