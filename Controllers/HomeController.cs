using Microsoft.AspNetCore.Mvc;

namespace UniRaters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // handle GET requests to /api/home
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API is working");
        }
    }
}
