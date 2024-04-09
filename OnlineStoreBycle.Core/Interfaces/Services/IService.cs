using OnlineStoreBycle.Core.Interfaces.Markers;

namespace OnlineStoreBycle.Core.Interfaces.Services;

public interface IService<T> where T : IModel
{
    Task AddAsync(T model);
    Task DeleteAsync(T model);
    Task<T?> GetModelAsync(int id);
    Task<IEnumerable<T>> GetModelsAsync();
    Task UpdateAsync(T model);
}