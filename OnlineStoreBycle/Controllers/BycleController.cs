using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class BycleController : ControllerBase
{
    private readonly IService<Bycle> _service;

    public BycleController(IService<Bycle> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] Bycle bycle)
    {
        await _service.AddAsync(bycle);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<Bycle>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Bycle?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Bycle bycle)
    {
        await _service.UpdateAsync(bycle);
    }
}