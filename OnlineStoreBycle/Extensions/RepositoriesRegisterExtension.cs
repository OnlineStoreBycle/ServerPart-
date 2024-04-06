using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Repositories;

namespace OnlineStoreBycle.Extensions;

internal static class RepositoriesRegisterExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRepositories<BrandBycle>, BrandBycleRepository>();
        services.AddScoped<IRepositories<Bycle>, BycleRepository>();
        services.AddScoped<IRepositories<BycleType>, BycleTypeRepository>();
        services.AddScoped<IRepositories<Client>, ClientRepository>();
        services.AddScoped<IRepositories<FrameSize>, FrameSizeRepository>();
        services.AddScoped<IRepositories<NumberBycle>, NumberBycleRepository>();
        services.AddScoped<IRepositories<Order>, OrderRepository>();
        services.AddScoped<IRepositories<OrderBycle>, OrderBycleRepository>();
        services.AddScoped<IRepositories<Price>, PriceRepository>();
        services.AddScoped<IRepositories<Review>, ReviewRepository>();
        services.AddScoped<IRepositories<Status>, StatusRepository>();

        return services;
    }
}