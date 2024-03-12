namespace OnlineStoreBycle.DAL.Entites;

public sealed class BycleTypeEntity
{
    public int Id { get; set; }
    public string TypeName { get; set; } = string.Empty;
    public IEnumerable<BycleEntity> Bycles { get; set; } = [];
}