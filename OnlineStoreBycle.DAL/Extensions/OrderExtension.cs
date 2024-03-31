using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class OrderExtension
{
    public static Order ToModel(this OrderEntity entity)
        => new(
            entity.Id,
            entity.ClientId,
            entity.StatusId,
            entity.Number,
            entity.Type,
            entity.PaymentMethod,
            entity.AddressReturn,
            entity.DateBegin,
            entity.DateEnd,
            entity.Client.ToModel(),
            entity.Status.ToModel(),
            entity.OrderBycles.ToModels()
        );

    public static IEnumerable<Order> ToModels(this IEnumerable<OrderEntity> entities)
        => entities.Select(x => x.ToModel());

    public static OrderEntity FromModel(this Order order)
        => new()
        {
            ClientId = order.ClientId,
            StatusId = order.StatusId,
            Number = order.Number,
            Type = order.Type,
            PaymentMethod = order.PaymentMethod,
            AddressReturn = order.AddressReturn,
            DateBegin = order.DateBegin,
            DateEnd = order.DateEnd
        };

    public static IEnumerable<OrderEntity> FromModels(this IEnumerable<Order> models)
        => models.Select(x => x.FromModel());
}