using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Entites;

namespace OnlineStoreBycle.DAL.Extensions;

internal static class ClientExtension
{
    public static Client ToModel(this ClientEntity entity)
        => new(
            entity.Id,
            entity.Name,
            entity.Password,
            entity.Email,
            entity.Phone,
            entity.Address
        );

    public static IEnumerable<Client> ToModels(this IEnumerable<ClientEntity> entities)
        => entities.Select(x => x.ToModel());

    public static ClientEntity FromModel(this Client model)
        => new()
        {
            Name = model.Name,
            Password = model.Password,
            Email = model.Email,
            Phone = model.Phone,
            Address = model.Address
        };

    public static IEnumerable<ClientEntity> FromModels(this IEnumerable<Client> models)
        => models.Select(x => x.FromModel());
}