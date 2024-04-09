using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class BycleRepository : IRepositories<Bycle>
{
    private readonly OnlineStoreBycleDbContext _context;

    public BycleRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Bycle model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Bycle model)
    {
        await _context.Bycles
            .Where(x => x.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<Bycle?> GetModelAsync(int id)
    {
        return (await _context.Bycles
            .AsNoTracking()
            .Include(x => x.BrandBycle)
            .Include(x => x.BycleType)
            .Include(x => x.FrameSize)
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task<IEnumerable<Bycle>> GetModelsAsync()
    {
        return (await _context.Bycles
            .AsNoTracking()
            .Include(x => x.BrandBycle)
            .Include(x => x.BycleType)
            .Include(x => x.FrameSize)
            .ToListAsync())
            .ToModels();
    }

    public async Task UpdateAsync(Bycle model)
    {
        await _context.Bycles
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.BrandId, model.BrandId)
                .SetProperty(p => p.TypeId, model.TypeId)
                .SetProperty(p => p.FrameSizeId, model.FrameSizeId)
                .SetProperty(p => p.IsBooked, model.IsBooked)
                .SetProperty(p => p.FrameMaterialName, model.FrameMaterialName)
                .SetProperty(p => p.Weight, model.Weight)
                .SetProperty(p => p.WheelDiameter, model.WheelDiameter)
                .SetProperty(p => p.CountSpeed, model.CountSpeed)
                .SetProperty(p => p.IsDepreciation, model.IsDepreciation)
                .SetProperty(p => p.ImageLink, model.ImageLink)
                .SetProperty(p => p.Title, model.Title)
            );
    }
}