namespace OnlineStoreBycle.DAL.Entites;

public sealed class StatusEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<OrderEntity> Orders { get; set; } = [];
}