using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class PriceRepository : IRepository<Price>
{
    private readonly OnlineStoreBycleDbContext _context;

    public PriceRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Price model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _context.Prices
            .Where(w => w.Id == id)
            .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<Price>> GetAsync()
    {
        return (await _context.Prices
            .AsNoTracking()
            .Include(x => x.Bycle)
            .ToListAsync())
            .ToModels();
    }

    public async Task<Price?> GetAsync(int id)
    {
        return (await _context.Prices
            .AsNoTracking()
            .Include(x => x.Bycle)
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task UpdateAsync(Price model)
    {
        await _context.Prices
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.BycleId, model.BycleId)
                .SetProperty(p => p.Value, model.Value)
                .SetProperty(p => p.DateBegin, model.DateBegin)
                .SetProperty(p => p.DateEnd, model.DateEnd)
            );
    }
}