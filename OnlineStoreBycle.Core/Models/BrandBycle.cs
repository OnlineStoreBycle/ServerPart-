namespace OnlineStoreBycle.Core.Models;

public sealed record BrandBycle(
    int Id,
    string Name,
    IEnumerable<Bycle> Bycles
);