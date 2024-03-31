using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class BycleExtension
{
    public static Bycle ToModel(this BycleEntity entity)
        => new(
            entity.Id,
            entity.BrandId,
            entity.TypeId,
            entity.FrameSizeId,
            entity.IsBooked,
            entity.FrameMaterialName,
            entity.Weight,
            entity.WheelDiameter,
            entity.CountSpeed,
            entity.IsDepreciation,
            entity.ImageLink,
            entity.Title,
            entity.BrandBycle.ToModel(),
            entity.BycleType.ToModel(),
            entity.FrameSize.ToModel(),
            entity.Reviews.ToModels(),
            entity.Prices.ToModels(),
            entity.NumberBycles.ToModels()
        );

    public static IEnumerable<Bycle> ToModels(this IEnumerable<BycleEntity> entities)
        => entities.Select(x => x.ToModel());

    public static BycleEntity FromModel(this Bycle model)
        => new()
        {
            BrandId = model.BrandId,
            TypeId = model.TypeId,
            FrameSizeId = model.FrameSizeId,
            IsBooked = model.IsBooked,
            FrameMaterialName = model.FrameMaterialName,
            Weight = model.Weight,
            WheelDiameter = model.WheelDiameter,
            CountSpeed = model.CountSpeed,
            IsDepreciation = model.IsDepreciation,
            ImageLink = model.ImageLink,
            Title = model.Title
        };

    public static IEnumerable<BycleEntity> FromModels(this IEnumerable<Bycle> models)
        => models.Select(x => x.FromModel());
}