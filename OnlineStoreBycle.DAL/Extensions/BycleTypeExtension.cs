﻿using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class BycleTypeExtension
{
    public static BycleType ToModel(this BycleTypeEntity entity)
        => new(
            entity.Id,
            entity.TypeName,
            entity.Bycles.ToModels()
        );

    public static IEnumerable<BycleType> ToModels(this IEnumerable<BycleTypeEntity> entities)
        => entities.Select(x => x.ToModel());
}