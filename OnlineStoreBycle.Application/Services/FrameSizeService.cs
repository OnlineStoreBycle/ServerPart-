using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class FrameSizeService : IService<FrameSize>
{
    private readonly IRepository<FrameSize> _repository;

    public FrameSizeService(IRepository<FrameSize> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(FrameSize model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<FrameSize>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<FrameSize?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(FrameSize model)
    {
        await _repository.UpdateAsync(model);
    }
}