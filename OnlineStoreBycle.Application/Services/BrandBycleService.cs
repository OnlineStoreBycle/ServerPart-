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

    public async Task DeleteAsync(BrandBycle model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<BrandBycle?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<BrandBycle>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(BrandBycle model)
    {
        await _repository.UpdateAsync(model);
    }
}