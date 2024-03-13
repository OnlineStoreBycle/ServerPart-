using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class BycleTypeExtension
{
    public static BycleType ToModel(this BycleTypeEntity entity)
        => new(
            entity.Id,
            entity.TypeName,
            entity.Bycles.Select(x => x.ToModel())
        );
}