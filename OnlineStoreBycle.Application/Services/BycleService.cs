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

    public async Task<Bycle?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<Bycle>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(Bycle model)
    {
        await _repository.UpdateAsync(model);
    }
}