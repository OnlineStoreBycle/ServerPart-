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

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<OrderBycle>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<OrderBycle?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(OrderBycle model)
    {
        await _repository.UpdateAsync(model);
    }
}