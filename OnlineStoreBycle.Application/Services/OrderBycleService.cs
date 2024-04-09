using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class OrderBycleService : IService<OrderBycle>
{
    private readonly IRepository<OrderBycle> _repository;

    public OrderBycleService(IRepository<OrderBycle> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(OrderBycle model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(OrderBycle model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<OrderBycle?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<OrderBycle>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(OrderBycle model)
    {
        await _repository.UpdateAsync(model);
    }
}