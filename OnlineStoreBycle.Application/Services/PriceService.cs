using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class PriceService : IService<Price>
{
    private readonly IRepository<Price> _repository;

    public PriceService(IRepository<Price> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Price model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(Price model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<Price?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<Price>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(Price model)
    {
        await _repository.UpdateAsync(model);
    }
}