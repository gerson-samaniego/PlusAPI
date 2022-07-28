using Microsoft.AspNetCore.Mvc;

namespace PlusAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PlusAPI : ControllerBase
{
    private readonly ILogger<PlusAPI> _logger;

    public PlusAPI(ILogger<PlusAPI> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "CalcSum")]
    public int Get(int a, int b)
    {
        return a + b;
    }
}
