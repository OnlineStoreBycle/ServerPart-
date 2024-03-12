using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class BycleTypeRepository : IBycleTypeRepository
{
    private readonly OnlineStoreBycleDbContext _context;

    public BycleTypeRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BycleType>> Get()
    {
        return await _context.BycleTypeEntities
            .AsNoTracking()
            .Select(x => x.ToModel())
            .ToListAsync();
    }
}