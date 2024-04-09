using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record Client(
    int Id,
    string Name,
    string Password,
    string Email,
    string Phone,
    string Address
) : IModel;