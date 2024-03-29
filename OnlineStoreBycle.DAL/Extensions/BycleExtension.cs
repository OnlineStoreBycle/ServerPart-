﻿using OnlineStoreBycle.Core.Models;
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
            entity.Price,
            entity.IsBooked,
            entity.FrameMaterialName,
            entity.Weight,
            entity.WheelDiameter,
            entity.CountSpeed,
            entity.IsDepreciation,
            entity.ImageLink,
            entity.Title,
            entity.BycleType.ToModel()
        );
}