﻿using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record BrandBycle(
    int Id,
    string Name
) : IModel;