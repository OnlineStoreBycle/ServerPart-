namespace OnlineStoreBycle.DAL.Entites;

public sealed class BycleEntity
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int TypeId { get; set; }
    public int FrameSizeId { get; set; }
    public decimal Price { get; set; }
    public bool IsBooked { get; set; }
    public string? FrameMaterialName { get; set; }
    public decimal Weight { get; set; }
    public int WheelDiameter { get; set; }
    public int CountSpeed { get; set; }
    public bool IsDepreciation { get; set; }
    public string? ImageLink { get; set; }
    public string? Title { get; set; }
    public BycleTypeEntity BycleType { get; set; } = new();
}