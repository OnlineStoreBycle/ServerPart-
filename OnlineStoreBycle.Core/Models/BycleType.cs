using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record BycleType(
    int Id,
    string TypeName,
    IEnumerable<Bycle> Bycles
) : IModel;