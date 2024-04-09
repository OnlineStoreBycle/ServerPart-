using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record Status(
    int Id,
    string Name
) : IModel;