using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Core.Interfaces.Repositories;

public interface IBycleTypeRepository
{
    Task<IEnumerable<BycleType>> Get();
}