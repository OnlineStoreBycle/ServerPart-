namespace OnlineStoreBycle.DAL.Entites;

public sealed class FrameSizeEntity
{
    public int Id { get; set; }
    public int Size { get; set; }
    public IEnumerable<BycleEntity> Bycles { get; set; } = Enumerable.Empty<BycleEntity>();
}
