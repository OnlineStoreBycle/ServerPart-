using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class NumberBycleController : ControllerBase
{
    private readonly IService<NumberBycle> _service;

    public NumberBycleController(IService<NumberBycle> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] NumberBycle numberBycle)
    {
        await _service.AddAsync(numberBycle);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<NumberBycle>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<NumberBycle?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] NumberBycle numberBycle)
    {
        await _service.UpdateAsync(numberBycle);
    }
}