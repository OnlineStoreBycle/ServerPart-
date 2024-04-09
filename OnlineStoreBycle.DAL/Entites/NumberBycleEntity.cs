namespace OnlineStoreBycle.DAL.Entites;

public sealed class NumberBycleEntity
{
    public int Id { get; set; }
    public int BycleId { get; set; }
    public string Value { get; set; } = string.Empty;
    public BycleEntity Bycle { get; set; } = new();
    public ICollection<OrderBycleEntity> OrderBycles { get; set; } = [];
}