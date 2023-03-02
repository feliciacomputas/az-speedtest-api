using Microsoft.AspNetCore.Mvc;

namespace SpeedTestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SpeedTestController : ControllerBase
{
    [Route("ping")]
    [HttpGet]
    public string Ping()
    {
        return "PONG";
    }

}
