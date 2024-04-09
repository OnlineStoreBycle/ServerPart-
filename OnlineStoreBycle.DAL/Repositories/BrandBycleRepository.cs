using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class BrandBycleRepository : IRepository<BrandBycle>
{
    private readonly OnlineStoreBycleDbContext _context;

    public BrandBycleRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(BrandBycle model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(BrandBycle model)
    {
        await _context.BrandBycles
            .Where(x => x.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<BrandBycle>> GetAsync()
    {
        return (await _context.BrandBycles
            .AsNoTracking()
            .ToListAsync())
            .ToModels();
    }

    public async Task<BrandBycle?> GetAsync(int id)
    {
        return (await _context.BrandBycles
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task UpdateAsync(BrandBycle model)
    {
        await _context.BrandBycles
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.Name, model.Name)
            );
    }
}