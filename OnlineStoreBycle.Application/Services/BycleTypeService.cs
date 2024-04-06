using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Application.Services;

public sealed class BycleTypeService : IBycleTypeService
{
    private readonly IRepositories<BycleType> _repository;

    public BycleTypeService(IRepositories<BycleType> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<BycleType>> Get()
    {
        return await _repository.GetModelsAsync();
    }
}