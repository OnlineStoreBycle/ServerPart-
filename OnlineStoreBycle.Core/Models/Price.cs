using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record Price(
    int Id,
    int BycleId,
    decimal Value,
    DateTime DateBegin,
    DateTime DateEnd,
    Bycle Bycle
) : IModel;