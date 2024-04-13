using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class OrderBycleController : ControllerBase
{
    private readonly IService<OrderBycle> _service;

    public OrderBycleController(IService<OrderBycle> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] OrderBycle orderBycle)
    {
        await _service.AddAsync(orderBycle);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<OrderBycle>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<OrderBycle?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] OrderBycle orderBycle)
    {
        await _service.UpdateAsync(orderBycle);
    }
}