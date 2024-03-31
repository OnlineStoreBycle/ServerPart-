using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class OrderBycleExtension
{
    public static OrderBycle ToModel(this OrderBycleEntity entity)
        => new(
            entity.Id,
            entity.OrderId,
            entity.NumberBycleId,
            entity.IsLantern,
            entity.IsHelmet,
            entity.IsCastle,
            entity.Order.ToModel(),
            entity.NumberBycle.ToModel()
        );

    public static IEnumerable<OrderBycle> ToModels(this IEnumerable<OrderBycleEntity> entities)
        => entities.Select(entity => entity.ToModel());

    public static OrderBycleEntity FromModel(this OrderBycle model)
        => new()
        {
            OrderId = model.OrderId,
            NumberBycleId = model.NumberBycleId,
            IsLantern = model.IsLantern,
            IsHelmet = model.IsHelmet,
            IsCastle = model.IsCastle,
        };

    public static IEnumerable<OrderBycleEntity> FromModels(this IEnumerable<OrderBycle> models)
        => models.Select(x => x.FromModel());
}