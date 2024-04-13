using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class ClientController : ControllerBase
{
    private readonly IService<Client> _service;

    public ClientController(IService<Client> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] Client client)
    {
        await _service.AddAsync(client);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<Client>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Client?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Client client)
    {
        await _service.UpdateAsync(client);
    }
}