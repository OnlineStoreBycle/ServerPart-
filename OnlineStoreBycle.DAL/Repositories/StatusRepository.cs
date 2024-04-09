using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class StatusRepository : IRepository<Status>
{
    private readonly OnlineStoreBycleDbContext _context;

    public StatusRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Status model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Status model)
    {
        await _context.Statuses
            .Where(w => w.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<Status>> GetAsync()
    {
        return (await _context.Statuses
            .AsNoTracking()
            .ToListAsync())
            .ToModels();
    }

    public async Task<Status?> GetAsync(int id)
    {
        return (await _context.Statuses
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task UpdateAsync(Status model)
    {
        await _context.Statuses
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.Name, model.Name)
            );
    }
}