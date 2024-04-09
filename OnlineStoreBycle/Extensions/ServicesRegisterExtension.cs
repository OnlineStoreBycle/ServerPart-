using OnlineStoreBycle.Application.Services;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Extensions;

internal static class ServicesRegisterExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IService<BrandBycle>, BrandBycleService>();
        services.AddScoped<IService<Bycle>, BycleService>();
        services.AddScoped<IService<BycleType>, BycleTypeService>();
        services.AddScoped<IService<Client>, ClientService>();
        services.AddScoped<IService<FrameSize>, FrameSizeService>();
        services.AddScoped<IService<NumberBycle>, NumberBycleService>();
        services.AddScoped<IService<Order>, OrderService>();
        services.AddScoped<IService<OrderBycle>, OrderBycleService>();
        services.AddScoped<IService<Price>, PriceService>();
        services.AddScoped<IService<Review>, ReviewService>();
        services.AddScoped<IService<Status>, StatusService>();

        return services;
    }
}