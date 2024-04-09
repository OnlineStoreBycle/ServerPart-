using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class OrderService : IService<Order>
{
    private readonly IRepository<Order> _repository;

    public OrderService(IRepository<Order> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Order model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(Order model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<Order?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<Order>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(Order model)
    {
        await _repository.UpdateAsync(model);
    }
}