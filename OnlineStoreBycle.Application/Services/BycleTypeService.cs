using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class BycleTypeService : IService<BycleType>
{
    private readonly IRepository<BycleType> _repository;

    public BycleTypeService(IRepository<BycleType> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(BycleType model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(BycleType model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<IEnumerable<BycleType>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<BycleType?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(BycleType model)
    {
        await _repository.UpdateAsync(model);
    }
}