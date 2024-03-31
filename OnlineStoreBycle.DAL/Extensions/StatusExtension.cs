using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class StatusExtension
{
    public static Status ToModel(this StatusEntity entity)
        => new(
            entity.Id,
            entity.Name,
            entity.Orders.ToModels()
        );

    public static IEnumerable<Status> ToModels(this IEnumerable<StatusEntity> entities)
        => entities.Select(x => x.ToModel());

    public static StatusEntity FromModel(this Status model)
        => new()
        {
            Name = model.Name
        };

    public static IEnumerable<StatusEntity> FromModels(this IEnumerable<Status> models)
        => models.Select(x => x.FromModel());
}