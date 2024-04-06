namespace OnlineStoreBycle.DAL.Entites;

public sealed class OrderEntity
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int StatusId { get; set; }
    public string Number { get; set; } = string.Empty;
    public string TypeName { get; set; } = string.Empty;
    public string PaymentMethod { get; set; } = string.Empty;
    public string AddressReturn { get; set; } = string.Empty;
    public DateTime DateBegin { get; set; }
    public DateTime DateEnd { get; set; }
    public ClientEntity Client { get; set; } = new();
    public StatusEntity Status { get; set; } = new();
    public IEnumerable<OrderBycleEntity> OrderBycles { get; set; } = [];
}