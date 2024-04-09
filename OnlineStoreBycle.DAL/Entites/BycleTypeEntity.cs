namespace OnlineStoreBycle.DAL.Entites;

public sealed class BycleTypeEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<BycleEntity> Bycles { get; set; } = [];
}