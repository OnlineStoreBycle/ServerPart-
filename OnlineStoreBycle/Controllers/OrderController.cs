using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class OrderController : ControllerBase
{
    private readonly IService<Order> _service;

    public OrderController(IService<Order> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] Order order)
    {
        await _service.AddAsync(order);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<Order>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Order?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Order order)
    {
        await _service.UpdateAsync(order);
    }
}