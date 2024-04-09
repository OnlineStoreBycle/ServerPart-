using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public class FrameSizeRepository : IRepositories<FrameSize>
{
    private readonly OnlineStoreBycleDbContext _context;

    public FrameSizeRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(FrameSize model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(FrameSize model)
    {
        await _context.FrameSizes
            .Where(w => w.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<FrameSize?> GetModelAsync(int id)
    {
        return (await _context.FrameSizes
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task<IEnumerable<FrameSize>> GetModelsAsync()
    {
        return (await _context.FrameSizes
            .AsNoTracking()
            .ToListAsync())
            .ToModels();
    }

    public async Task UpdateAsync(FrameSize model)
    {
        await _context.FrameSizes
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.Value, model.Value)
            );
    }
}