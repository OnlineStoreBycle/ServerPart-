using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record NumberBycle(
    int Id,
    int BycleId,
    string Value,
    Bycle Bycle
) : IModel;