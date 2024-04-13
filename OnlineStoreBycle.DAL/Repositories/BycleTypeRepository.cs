using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class BycleTypeRepository : IRepository<BycleType>
{
    private readonly OnlineStoreBycleDbContext _context;

    public BycleTypeRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(BycleType model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _context.BycleTypes
            .Where(x => x.Id == id)
            .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<BycleType>> GetAsync()
    {
        return (await _context.BycleTypes
            .AsNoTracking()
            .ToListAsync())
            .ToModels();
    }

    public async Task<BycleType?> GetAsync(int id)
    {
        return (await _context.BycleTypes
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task UpdateAsync(BycleType model)
    {
        await _context.BycleTypes
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.Name, model.Name)
            );
    }
}