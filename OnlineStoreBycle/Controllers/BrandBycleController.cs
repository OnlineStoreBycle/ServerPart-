using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class BrandBycleController : Controller
{
    private readonly IService<BrandBycle> _service;

    public BrandBycleController(IService<BrandBycle> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] BrandBycle brandBycle)
    {
        await _service.AddAsync(brandBycle);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<BrandBycle>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<BrandBycle?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] BrandBycle brandBycle)
    {
        await _service.UpdateAsync(brandBycle);
    }
}