namespace OnlineStoreBycle.DAL.Entites;

public sealed class OrderBycleEntity
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int NumberBycleId { get; set; }
    public bool IsLantern { get; set; }
    public bool IsHelmet { get; set; }
    public bool IsCastle { get; set; }
    public OrderEntity Order { get; set; } = new();
    public NumberBycleEntity NumberBycle { get; set; } = new();
}