using Microsoft.EntityFrameworkCore;
using OnlineStoreBycle.Core.Interfaces.Repositories;
using OnlineStoreBycle.Core.Models;
using OnlineStoreBycle.DAL.Context;
using OnlineStoreBycle.DAL.Extensions;

namespace OnlineStoreBycle.DAL.Repositories;

public sealed class ClientRepository : IRepositories<Client>
{
    private readonly OnlineStoreBycleDbContext _context;

    public ClientRepository(OnlineStoreBycleDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Client model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Client model)
    {
        await _context.Clients
            .Where(w => w.Id == model.Id)
            .ExecuteDeleteAsync();
    }

    public async Task<Client?> GetModelAsync(int id)
    {
        return (await _context.Clients
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task<IEnumerable<Client>> GetModelsAsync()
    {
        return (await _context.Clients
            .AsNoTracking()
            .ToListAsync())
            .ToModels();
    }

    public async Task UpdateAsync(Client model)
    {
        await _context.Clients
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.Name, model.Name)
                .SetProperty(p => p.Password, model.Password)
                .SetProperty(p => p.Email, model.Email)
                .SetProperty(p => p.Phone, model.Phone)
                .SetProperty(p => p.Address, model.Address)
            );
    }
}