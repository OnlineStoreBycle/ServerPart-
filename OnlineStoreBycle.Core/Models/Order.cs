using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Models;

public sealed record Order(
    int Id,
    int ClientId,
    int StatusId,
    string Number,
    string TypeName,
    string PaymentMethod,
    string AddressReturn,
    DateTime DateBegin,
    DateTime DateEnd,
    Client Client,
    Status Status
) : IModel;