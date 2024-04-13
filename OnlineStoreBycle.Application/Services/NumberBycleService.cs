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

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<NumberBycle>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<NumberBycle?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(NumberBycle model)
    {
        await _repository.UpdateAsync(model);
    }
}