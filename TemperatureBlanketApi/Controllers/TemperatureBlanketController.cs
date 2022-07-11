using Microsoft.AspNetCore.Mvc;
using TemperatureBlanketApi.Interfaces;
using TemperatureBlanketApi.Services;

namespace TemperatureBlanketApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TemperatureBlanketController : ControllerBase
{
    private readonly IBlanketService _blanketService;

    public TemperatureBlanketController(IBlanketService blanketService)
    {
        _blanketService = blanketService;
    }

    [HttpGet("GetDummyBlanket")]
    public IActionResult GetDummyBlanket()
    {
        return Ok(_blanketService.CreateDummyBlanket());
    }

}