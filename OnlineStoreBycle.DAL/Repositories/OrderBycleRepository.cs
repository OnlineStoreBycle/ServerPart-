using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class OrderBycleRepository : IRepository<OrderBycle>
{
    private readonly OnlineStoreBycleDbContext _context;

    public OrderBycleRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(OrderBycle model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(OrderBycle model)
    {
        await _context.OrderBycles
            .Where(w => w.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<OrderBycle>> GetAsync()
    {
        return (await _context.OrderBycles
            .AsNoTracking()
            .Include(x => x.Order)
            .Include(x => x.NumberBycle)
            .ToListAsync())
            .ToModels();
    }

    public async Task<OrderBycle?> GetAsync(int id)
    {
        return (await _context.OrderBycles
            .AsNoTracking()
            .Include(x => x.Order)
            .Include(x => x.NumberBycle)
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task UpdateAsync(OrderBycle model)
    {
        await _context.OrderBycles
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.OrderId, model.OrderId)
                .SetProperty(p => p.NumberBycleId, model.NumberBycleId)
                .SetProperty(p => p.IsLantern, model.IsLantern)
                .SetProperty(p => p.IsHelmet, model.IsHelmet)
                .SetProperty(p => p.IsCastle, model.IsCastle)
            );
    }
}