using Microsoft.AspNetCore.Mvc;

namespace AiDocumentAnalyzer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Status = "healthy",
            Timestamp = DateTime.UtcNow
        });
    }
}
