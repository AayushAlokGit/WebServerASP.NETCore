using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_API_Project.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{

    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Hello()
    {
        return "Hello from server";
    }
}
