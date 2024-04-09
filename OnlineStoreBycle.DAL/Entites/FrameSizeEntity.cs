namespace OnlineStoreBycle.DAL.Entites;

public sealed class FrameSizeEntity
{
    public int Id { get; set; }
    public int Value { get; set; }
    public ICollection<BycleEntity> Bycles { get; set; } = [];
}