namespace OnlineStoreBycle.DAL.Entites;

public sealed class ReviewsEntity
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int BycleId { get; set; }
    public BycleEntity Bycle { get; set; } = new();
}
