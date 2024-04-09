using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Repositories;

namespace OnlineStoreBycle.Extensions;

internal static class RepositoriesRegisterExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRepository<BrandBycle>, BrandBycleRepository>();
        services.AddScoped<IRepository<Bycle>, BycleRepository>();
        services.AddScoped<IRepository<BycleType>, BycleTypeRepository>();
        services.AddScoped<IRepository<Client>, ClientRepository>();
        services.AddScoped<IRepository<FrameSize>, FrameSizeRepository>();
        services.AddScoped<IRepository<NumberBycle>, NumberBycleRepository>();
        services.AddScoped<IRepository<Order>, OrderRepository>();
        services.AddScoped<IRepository<OrderBycle>, OrderBycleRepository>();
        services.AddScoped<IRepository<Price>, PriceRepository>();
        services.AddScoped<IRepository<Review>, ReviewRepository>();
        services.AddScoped<IRepository<Status>, StatusRepository>();

        return services;
    }
}