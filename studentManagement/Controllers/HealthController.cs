using Microsoft.AspNetCore.Mvc;

namespace studentManagement.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Health()
        {
            return Ok(new
            {
                status=200,
                message = "working properly",
                desc = "student managemennt system"
            });
        }
    }
}
