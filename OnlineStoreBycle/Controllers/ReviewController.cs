using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class ReviewController : ControllerBase
{
    private readonly IService<Review> _service;

    public ReviewController(IService<Review> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] Review review)
    {
        await _service.AddAsync(review);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<Review>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Review?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Review review)
    {
        await _service.UpdateAsync(review);
    }
}