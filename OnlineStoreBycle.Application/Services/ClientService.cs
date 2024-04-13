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

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Client>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<Client?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(Client model)
    {
        await _repository.UpdateAsync(model);
    }
}