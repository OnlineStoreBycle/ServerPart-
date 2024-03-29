﻿using Microsoft.AspNetCore.Mvc;
using OnlineStoreBycle.Core.Interfaces.Services;
using OnlineStoreBycle.Core.Models;

namespace OnlineStoreBycle.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BycleTypeController : Controller
{
    private readonly IBycleTypeService _service;

    public BycleTypeController(IBycleTypeService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<BycleType>> Get()
    {
        return await _service.Get();
    }
}