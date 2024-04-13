using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class StatusController : ControllerBase
{
    private readonly IService<Status> _service;

    public StatusController(IService<Status> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] Status status)
    {
        await _service.AddAsync(status);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<Status>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Status?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Status status)
    {
        await _service.UpdateAsync(status);
    }
}