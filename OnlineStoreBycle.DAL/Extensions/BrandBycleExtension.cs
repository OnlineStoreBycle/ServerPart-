using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class BrandBycleExtension
{
    public static BrandBycle ToModel(this BrandBycleEntity entity)
        => new(
            entity.Id,
            entity.Name,
            entity.Bycles.ToModels()
        );

    public static IEnumerable<BrandBycle> ToModels(this IEnumerable<BrandBycleEntity> entities)
        => entities.Select(x => x.ToModel());

    public static BrandBycleEntity FromModel(this BrandBycle model)
        => new()
        {
            Name = model.Name
        };

    public static IEnumerable<BrandBycleEntity> FromModels(this IEnumerable<BrandBycle> models)
        => models.Select(x => x.FromModel());
}
