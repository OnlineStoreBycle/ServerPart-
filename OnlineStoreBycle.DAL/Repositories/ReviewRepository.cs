using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class ReviewRepository : IRepository<Review>
{
    private readonly OnlineStoreBycleDbContext _context;

    public ReviewRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Review model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Review model)
    {
        await _context.Reviews
            .Where(w => w.Id == model.Id)
            .ExecuteDeleteAsync();
    } 

    public async Task<IEnumerable<Review>> GetAsync()
    {
        return (await _context.Reviews
            .AsNoTracking()
            .Include(x => x.Bycle)
            .ToListAsync())
            .ToModels();
    }

    public async Task<Review?> GetAsync(int id)
    {
        return (await _context.Reviews
            .AsNoTracking()
            .Include(x => x.Bycle)
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task UpdateAsync(Review model)
    {
        await _context.Reviews
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.BycleId, model.BycleId)
                .SetProperty(p => p.Text, model.Text)
            );
    }
}