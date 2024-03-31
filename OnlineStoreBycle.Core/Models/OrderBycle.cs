using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record OrderBycle(
    int Id,
    int OrderId,
    int NumberBycleId,
    bool IsLantern,
    bool IsHelmet,
    bool IsCastle,
    Order Order,
    NumberBycle NumberBycle
) : IModel;