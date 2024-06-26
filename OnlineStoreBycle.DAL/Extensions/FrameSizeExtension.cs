﻿using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class FrameSizeExtension
{
    public static FrameSize ToModel(this FrameSizeEntity entity)
        => new(
            entity.Id,
            entity.Value
        );

    public static IEnumerable<FrameSize> ToModels(this IEnumerable<FrameSizeEntity> entities)
        => entities.Select(x => x.ToModel());

    public static FrameSizeEntity FromModel(this FrameSize model)
        => new()
        {
            Value = model.Value
        };

    public static IEnumerable<FrameSizeEntity> FromModels(this IEnumerable<FrameSize> models)
        => models.Select(x => x.FromModel());
}
