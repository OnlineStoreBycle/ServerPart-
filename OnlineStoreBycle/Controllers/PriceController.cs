using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class PriceController : ControllerBase
{
    private readonly IService<Price> _service;

    public PriceController(IService<Price> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] Price price)
    {
        await _service.AddAsync(price);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<Price>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Price?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Price price)
    {
        await _service.UpdateAsync(price);
    }
}