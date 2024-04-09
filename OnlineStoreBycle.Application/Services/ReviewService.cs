using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class ReviewService : IService<Review>
{
    private readonly IRepository<Review> _repository;

    public ReviewService(IRepository<Review> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Review model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(Review model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<Review?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<Review>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(Review model)
    {
        await _repository.UpdateAsync(model);
    }
}