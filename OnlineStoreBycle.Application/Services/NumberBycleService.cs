using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class NumberBycleService : IService<NumberBycle>
{
    private readonly IRepository<NumberBycle> _repository;

    public NumberBycleService(IRepository<NumberBycle> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(NumberBycle model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(NumberBycle model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<NumberBycle?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<NumberBycle>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(NumberBycle model)
    {
        await _repository.UpdateAsync(model);
    }
}