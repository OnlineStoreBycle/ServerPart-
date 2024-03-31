using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class PriceExtension
{
    public static Price ToModel(this PriceEntity entity)
        => new(
            entity.Id,
            entity.BycleId,
            entity.Value,
            entity.DateBegin,
            entity.DateEnd,
            entity.Bycle.ToModel()
        );

    public static IEnumerable<Price> ToModels(this IEnumerable<PriceEntity> entities)
        => entities.Select(x => x.ToModel());

    public static PriceEntity FromModel(this Price model)
        => new()
        {
            BycleId = model.BycleId,
            Value = model.Value,
            DateBegin = model.DateBegin,
            DateEnd = model.DateEnd
        };

    public static IEnumerable<PriceEntity> FromModels(this IEnumerable<Price> models)
        => models.Select(x => x.FromModel());
}