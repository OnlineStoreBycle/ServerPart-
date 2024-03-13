namespace OnlineStoreBycle.DAL.Entites;

public sealed class BrandBycleEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public IEnumerable<BycleEntity> Bycles { get; set; } = Enumerable.Empty<BycleEntity>();
}
