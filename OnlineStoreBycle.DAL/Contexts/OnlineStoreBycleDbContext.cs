using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.DAL.Configurations;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Context;

public sealed class OnlineStoreBycleDbContext : DbContext
{
    public OnlineStoreBycleDbContext(DbContextOptions<OnlineStoreBycleDbContext> options) : base(options) { }

    public DbSet<BrandBycleEntity> BrandBycleEntities { get; set; }
    public DbSet<BycleEntity> BycleEntities { get; set; }
    public DbSet<BycleTypeEntity> BycleTypeEntities { get; set; }
    public DbSet<ClientEntity> ClientEntities { get; set; }
    public DbSet<FrameSizeEntity> FrameSizeEntities { get; set; }
    public DbSet<NumberBycleEntity> NumberBycleEntities { get; set; }
    public DbSet<OrderBycleEntity> OrderBycleEntities { get; set; }
    public DbSet<OrderEntity> OrderEntities { get; set; }
    public DbSet<PriceEntity> PriceEntities { get; set; }
    public DbSet<ReviewEntity> ReviewEntities { get; set; }
    public DbSet<StatusEntity> StatusEntities { get; set; }

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