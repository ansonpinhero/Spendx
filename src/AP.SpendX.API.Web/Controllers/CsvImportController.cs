using Microsoft.AspNetCore.Mvc;

namespace AP.SpendX.API.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CsvImportController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> ImportCsv(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        return Ok("Imported");
    }
    
}