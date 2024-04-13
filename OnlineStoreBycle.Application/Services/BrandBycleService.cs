using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class BrandBycleService : IService<BrandBycle>
{
    private readonly IRepository<BrandBycle> _repository;

    public BrandBycleService(IRepository<BrandBycle> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(BrandBycle model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<BrandBycle>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<BrandBycle?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(BrandBycle model)
    {
        await _repository.UpdateAsync(model);
    }
}