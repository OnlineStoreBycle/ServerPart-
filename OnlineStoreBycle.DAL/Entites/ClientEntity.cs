namespace OnlineStoreBycle.DAL.Entites;

public sealed class ClientEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public IEnumerable<OrderEntity> Orders { get; set; } = [];
}