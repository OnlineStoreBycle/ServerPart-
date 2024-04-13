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

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Status>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<Status?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(Status model)
    {
        await _repository.UpdateAsync(model);
    }
}