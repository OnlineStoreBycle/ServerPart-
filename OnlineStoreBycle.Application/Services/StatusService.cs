using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class StatusService : IService<Status>
{
    private readonly IRepository<Status> _repository;

    public StatusService(IRepository<Status> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Status model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(Status model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<Status?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<Status>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(Status model)
    {
        await _repository.UpdateAsync(model);
    }
}