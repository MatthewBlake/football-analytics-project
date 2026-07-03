using Microsoft.AspNetCore.Mvc;
using FootballAnalyticsProject.Fixtures.Domain.Entities;
using FootballAnalyticsProject.Fixtures.Api.Contracts.Teams;

namespace FootballAnalyticsProject.Fixtures.Api.Controllers
{
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly TeamStore _teamStore;

        public TeamController(TeamStore teamStore)
        {
            _teamStore = teamStore;
        }

        [HttpGet]
        [Route("api/v1/[controller]")]
        public ActionResult<List<TeamResponse>> GetTeam()
        {
            List<TeamResponse> result = new List<TeamResponse>();
            foreach (Team team in _teamStore.teamList)
            {
                TeamResponse teamResponse = new TeamResponse
                { 
                    Id = team.Id,
                    Name = team.Name,
                    Colour = team.Colour
                };


                result.Add(teamResponse);
            }
            return Ok(result);
        }


        [HttpPost]
        [Route("api/v1/[controller]")]
        public ActionResult<TeamResponse> PostTeam(CreateTeamRequest request)
        {
            Team team = new Team(request.Name, request.Colour);

            _teamStore.teamList.Add(team);

            TeamResponse result = new TeamResponse
            {
                Id = team.Id,
                Name = request.Name,
                Colour = request.Colour
            };

            return Ok(result);
        }

        //TODO: Come back later once storage is implemented
        //[HttpPut]
        //[Route("api/v1/[controller]/{id}")]
        //public ActionResult<TeamResponse> PutTeam(UpdateTeamRequest request)
        //{
        //    Team team = new Team
        //    {
        //        TeamName = request.TeamName,
        //        TeamColour = request.TeamColour
        //    };

        //    TeamResponse result = new TeamResponse
        //    {
        //        TeamName = request.TeamName,
        //        TeamColour = request.TeamColour
        //    };

        //    return Ok(result);
        //}
    }
}
