using FootballAnalyticsProject.Fixtures.Api.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FootballAnalyticsProject.Fixtures.Api.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("api/v1/[controller]")]
        public ActionResult<HealthResponse> GetHealth()
        {
            HealthResponse result = new HealthResponse() 
            { 
                Status = "Healthy"
            };
            return Ok(result);
        }
    }
}
