using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record Bycle(
    int Id,
    int BrandId,
    int TypeId,
    int FrameSizeId,
    decimal Price,
    bool IsBooked,
    string? FrameMaterialName,
    decimal Weight,
    int WheelDiameter,
    int CountSpeed,
    bool IsDepreciation,
    string? ImageLink,
    string? Title,
    BycleType BycleType,
    BrandBycle BrandBycle,
    FrameSize FrameSize,
    IEnumerable<Review> Reviews
) : IModel;