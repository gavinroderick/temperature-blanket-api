using Microsoft.AspNetCore.Mvc;
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

    [HttpGet(Name = "GetBlanket")]
    public IActionResult GetBlanket()
    {
        return Ok(_blanketService.GetDummyBlanket());
    }
}