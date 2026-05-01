using Microsoft.AspNetCore.Mvc;

namespace studentManagement.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HealthController : ControllerBase
    {
        public readonly IConfiguration _configuration;
        public HealthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Health()
        {
            return Ok(new
            {

                status=200,
                Isactive=true,
                iswrokingFile=true,
                message = "working properly",
                environment = _configuration["ApplicationSettings:ApplicationName"],
                supportEmail = _configuration["ApplicationSettings:SupportEmail"],
                desc = "student managemennt system",
                isrunning = true,
                studentPortal = _configuration["ExternalServices:studentPortal"]
            });
        }
    }
}
