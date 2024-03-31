namespace OnlineStoreBycle.DAL.Entites;

public sealed class PriceEntity
{
    public int Id { get; set; }
    public int BycleId { get; set; }
    public decimal Value { get; set; }
    public DateTime DateBegin { get; set; }
    public DateTime DateEnd { get; set; }
    public BycleEntity Bycle { get; set; } = new();
}