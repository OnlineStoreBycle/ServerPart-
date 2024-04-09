using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class BycleService : IService<Bycle>
{
    private readonly IRepository<Bycle> _repository;

    public BycleService(IRepository<Bycle> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Bycle model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(Bycle model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<IEnumerable<Bycle>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<Bycle?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(Bycle model)
    {
        await _repository.UpdateAsync(model);
    }
}