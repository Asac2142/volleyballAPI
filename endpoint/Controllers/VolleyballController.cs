using endpoint.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VolleyballController : ControllerBase
    {
        private readonly ILogger<VolleyballController> _logger;

        public VolleyballController(ILogger<VolleyballController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/creatematch")]
        public IActionResult Post([FromBody] VolleyballMatch volleyballMatch)
        {
            if (volleyballMatch == null) return BadRequest("Match object is null");
            if (!ModelState.IsValid) return BadRequest("Invalid model object");
           
            return StatusCode(200, "Match received successfuly");
        }
    }
}
