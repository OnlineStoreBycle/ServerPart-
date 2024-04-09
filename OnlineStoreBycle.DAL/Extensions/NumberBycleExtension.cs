using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class NumberBycleExtension
{
    public static NumberBycle ToModel(this NumberBycleEntity entity)
        => new(
            entity.Id,
            entity.BycleId,
            entity.Value,
            entity.Bycle.ToModel()
        );

    public static IEnumerable<NumberBycle> ToModels(this IEnumerable<NumberBycleEntity> entities)
        => entities.Select(x => x.ToModel());

    public static NumberBycleEntity FromModel(this NumberBycle model)
        => new()
        {
            BycleId = model.BycleId,
            Value = model.Value
        };

    public static IEnumerable<NumberBycleEntity> FromModels(this IEnumerable<NumberBycle> models)
        => models.Select(x => x.FromModel());
}