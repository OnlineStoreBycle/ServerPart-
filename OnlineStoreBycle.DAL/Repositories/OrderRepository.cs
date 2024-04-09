using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class OrderRepository : IRepositories<Order>
{
    private readonly OnlineStoreBycleDbContext _context;

    public OrderRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Order model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Order model)
    {
        await _context.Orders
            .Where(w => w.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<Order?> GetModelAsync(int id)
    {
        return (await _context.Orders
            .AsNoTracking()
            .Include(x => x.Client)
            .Include(x => x.Status)
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task<IEnumerable<Order>> GetModelsAsync()
    {
        return (await _context.Orders
            .AsNoTracking()
            .Include(x => x.Client)
            .Include(x => x.Status)
            .ToListAsync())
            .ToModels();
    }

    public async Task UpdateAsync(Order model)
    {
        await _context.Orders
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.ClientId, model.ClientId)
                .SetProperty(p => p.StatusId, model.StatusId)
                .SetProperty(p => p.Number, model.Number)
                .SetProperty(p => p.TypeName, model.TypeName)
                .SetProperty(p => p.PaymentMethod, model.PaymentMethod)
                .SetProperty(p => p.AddressReturn, model.AddressReturn)
                .SetProperty(p => p.DateBegin, model.DateBegin)
                .SetProperty(p => p.DateEnd, model.DateEnd)
            );
    }
}