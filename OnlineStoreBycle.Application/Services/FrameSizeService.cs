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

    public async Task DeleteAsync(FrameSize model)
    {
        await _repository.DeleteAsync(model);
    }

    public async Task<FrameSize?> GetModelAsync(int id)
    {
        return await _repository.GetModelAsync(id);
    }

    public async Task<IEnumerable<FrameSize>> GetModelsAsync()
    {
        return await _repository.GetModelsAsync();
    }

    public async Task UpdateAsync(FrameSize model)
    {
        await _repository.UpdateAsync(model);
    }
}