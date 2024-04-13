using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class BycleTypeController : ControllerBase
{
    private readonly IService<BycleType> _service;

    public BycleTypeController(IService<BycleType> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] BycleType bycleType)
    {
        await _service.AddAsync(bycleType);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<BycleType>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<BycleType?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] BycleType bycleType)
    {
        await _service.UpdateAsync(bycleType);
    }
}