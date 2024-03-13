using OnlineStoreBycle.Application.Services;
using OnlineStoreBycle.Core.Interfaces.Services;

namespace OnlineStoreBycle.Extensions;

internal static class ServicesRegisterExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBycleTypeService, BycleTypeService>();

        return services;
    }
}