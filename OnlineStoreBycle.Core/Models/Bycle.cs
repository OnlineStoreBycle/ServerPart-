using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record Bycle(
    int Id,
    int BrandId,
    int TypeId,
    int FrameSizeId,
    int PriceId,
    bool IsBooked,
    string? FrameMaterialName,
    decimal Weight,
    int WheelDiameter,
    int CountSpeed,
    bool IsDepreciation,
    string? ImageLink,
    string? Title,
    BrandBycle BrandBycle,
    BycleType BycleType,
    FrameSize FrameSize,
    Price Price,
    IEnumerable<Review> Reviews,
    IEnumerable<NumberBycle> NumberBycles
) : IModel;