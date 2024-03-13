using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.DAL.Configurations;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Context;

public sealed class OnlineStoreBycleDbContext : DbContext
{
    public OnlineStoreBycleDbContext(DbContextOptions<OnlineStoreBycleDbContext> options) : base(options)
    {

    }

    public DbSet<BycleTypeEntity> BycleTypeEntities { get; set; }
    public DbSet<BrandBycleEntity> BrandBycleEntities { get; set; }
    public DbSet<FrameSizeEntity> FrameSizeEntities { get; set; }
    public DbSet<BycleEntity> BycleEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new BycleTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BrandBycleConfiguration());
        modelBuilder.ApplyConfiguration(new FrameSizeConfiguration());
        modelBuilder.ApplyConfiguration(new BycleEntityConfiguration());
    }
}