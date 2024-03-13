using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.DAL.Repositories;

namespace OnlineStoreBycle.Extensions;

internal static class RepositoriesRegisterExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBycleTypeRepository, BycleTypeRepository>();

        return services;
    }
}