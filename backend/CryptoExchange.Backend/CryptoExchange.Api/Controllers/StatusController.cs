using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CryptoExchange.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusController: ControllerBase
{
    [HttpGet("status-check")]
    public IActionResult GetStatus()
    {
        return Ok("Status: OK");
    }
}