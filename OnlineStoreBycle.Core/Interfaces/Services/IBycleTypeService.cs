using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Core.Interfaces.Services;

public interface IBycleTypeService
{
    Task<IEnumerable<BycleType>> Get();
}