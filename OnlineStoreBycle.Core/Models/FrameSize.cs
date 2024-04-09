using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record FrameSize(
    int Id,
    int Value
) : IModel;