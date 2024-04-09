using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class ClientService : IService<Client>
{
    private readonly IRepository<Client> _repository;

    public ClientService(IRepository<Client> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Client model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(Client model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<Client?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<Client>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(Client model)
    {
        await _repository.UpdateAsync(model);
    }
}