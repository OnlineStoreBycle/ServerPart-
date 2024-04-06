using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class NumberBycleRepository : IRepositories<NumberBycle>
{
    private readonly OnlineStoreBycleDbContext _context;

    public NumberBycleRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(NumberBycle model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(NumberBycle model)
    {
        await _context.NumberBycles
            .Where(w => w.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<NumberBycle?> GetModelAsync(int id)
    {
        return (await _context.NumberBycles
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task<IEnumerable<NumberBycle>> GetModelsAsync()
    {
        return (await _context.NumberBycles
            .AsNoTracking()
            .ToListAsync())
            .ToModels();
    }

    public async Task UpdateAsync(NumberBycle model)
    {
        await _context.NumberBycles
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.BycleId, model.BycleId)
                .SetProperty(p => p.Value, model.Value)
            );
    }
}