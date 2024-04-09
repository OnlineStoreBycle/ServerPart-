using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class BycleTypeExtension
{
    public static BycleType ToModel(this BycleTypeEntity entity)
        => new(
            entity.Id,
            entity.Name
        );

    public static IEnumerable<BycleType> ToModels(this IEnumerable<BycleTypeEntity> entities)
        => entities.Select(x => x.ToModel());

    public static BycleTypeEntity FromModel(this BycleType model)
        => new()
        {
            Name = model.Name
        };

    public static IEnumerable<BycleTypeEntity> FromModels(this IEnumerable<BycleType> models)
        => models.Select(x => x.FromModel());
}