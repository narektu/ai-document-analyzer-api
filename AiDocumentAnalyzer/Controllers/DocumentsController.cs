using Microsoft.AspNetCore.Mvc;

namespace AiDocumentAnalyzer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DocumentsController : ControllerBase
{
    [HttpPost("analyze")]
    public IActionResult Analyze()
    {
        return Ok(new { Message = "Not yet implemented" });
    }
}
