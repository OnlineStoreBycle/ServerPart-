using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.DAL.Configurations;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Context;

public sealed class OnlineStoreBycleDbContext : DbContext
{
    public OnlineStoreBycleDbContext(DbContextOptions<OnlineStoreBycleDbContext> options) : base(options) { }

    public DbSet<BrandBycleEntity> BrandBycles { get; set; }
    public DbSet<BycleEntity> Bycles { get; set; }
    public DbSet<BycleTypeEntity> BycleTypes { get; set; }
    public DbSet<ClientEntity> Clients { get; set; }
    public DbSet<FrameSizeEntity> FrameSizes { get; set; }
    public DbSet<NumberBycleEntity> NumberBycles { get; set; }
    public DbSet<OrderBycleEntity> OrderBycles { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<PriceEntity> Prices { get; set; }
    public DbSet<ReviewEntity> Reviews { get; set; }
    public DbSet<StatusEntity> Statuses{ get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new BrandBycleConfiguration());
        modelBuilder.ApplyConfiguration(new BycleTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BycleConfiguration());
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new FrameSizeConfiguration());
        modelBuilder.ApplyConfiguration(new NumberBycleConfiguration());
        modelBuilder.ApplyConfiguration(new OrderBycleConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new PriceConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewConfiguration());
        modelBuilder.ApplyConfiguration(new StatusConfiguration());
    }
}