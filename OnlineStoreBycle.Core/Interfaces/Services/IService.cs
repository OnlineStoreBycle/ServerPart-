using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Interfaces.Services;

public interface IService<T> where T : IModel
{
    Task AddAsync(T model);
    Task DeleteAsync(T model);
    Task<IEnumerable<T>> GetAsync();
    Task<T?> GetAsync(int id);
    Task UpdateAsync(T model);
}