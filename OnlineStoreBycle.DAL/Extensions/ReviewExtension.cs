using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class ReviewExtension
{
    public static Review ToModel(this ReviewEntity entity)
        => new(
            entity.Id,
            entity.Text,
            entity.BycleId,
            entity.Bycle.ToModel()
        );

    public static IEnumerable<Review> ToModels(this IEnumerable<ReviewEntity> entities)
        => entities.Select(x => x.ToModel());
}
