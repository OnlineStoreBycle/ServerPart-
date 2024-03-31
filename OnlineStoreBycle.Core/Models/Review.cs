using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record Review(
    int Id,
    string Text,
    int BycleId,
    Bycle Bycle
) : IModel;