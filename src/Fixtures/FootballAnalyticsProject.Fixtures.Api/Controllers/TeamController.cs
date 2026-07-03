using Microsoft.AspNetCore.Mvc;
using FootballAnalyticsProject.Fixtures.Domain.Entities;
using FootballAnalyticsProject.Fixtures.Api.Contracts.Teams;

namespace FootballAnalyticsProject.Fixtures.Api.Controllers
{
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpGet]
        [Route("api/v1/[controller]")]
        public ActionResult<TeamResponse> GetTeam()
        {
            TeamResponse result = new TeamResponse();
            result.TeamName = "Chelsea";
            result.TeamColour = "Blue";
            return Ok(result);
        }


        [HttpPost]
        [Route("api/v1/[controller]")]
        public ActionResult<TeamResponse> PostTeam(CreateTeamRequest request)
        {
            Team team = new Team
            {
                TeamName = request.TeamName,
                TeamColour = request.TeamColour
            };

            TeamResponse result = new TeamResponse
            {
                TeamName = request.TeamName,
                TeamColour = request.TeamColour
            };

            return Ok(result);
        }
    }
}
