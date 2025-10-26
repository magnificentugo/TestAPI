using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok(new { message = "Hello from TestApi!" });
        }

        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(new { status = "TestApi is running fine!", version = "v1.0" });
        }

        [HttpGet("Trial")]
        public IActionResult Gettrial()
        {
            return Ok(new { status = "TestApi trial mode running fine!", version = "v1.0" });
        }

        [HttpGet("Trial-Seg-ment")]
        public IActionResult GettrialSEG()
        {
            return Ok(new { status = "TestApi trial-segment mode running fine!", version = "v1.0" });
        }
    }
}
