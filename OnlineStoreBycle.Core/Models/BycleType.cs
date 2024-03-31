﻿using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record BycleType(
    int Id,
    string Name,
    IEnumerable<Bycle> Bycles
) : IModel;