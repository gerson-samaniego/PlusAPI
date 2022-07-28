using Microsoft.AspNetCore.Mvc;

namespace PlusAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlusAPI : ControllerBase
{
    private readonly ILogger<PlusAPI> _logger;

    public PlusAPI(ILogger<PlusAPI> logger)
    {
        _logger = logger;
    }

    [HttpGet("{a}/{b}")]
    public int sum(int a, int b) => a + b;
}
