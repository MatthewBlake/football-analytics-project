using FootballAnalyticsProject.Fixtures.Api.Contracts.Fixtures;
using FootballAnalyticsProject.Fixtures.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FootballAnalyticsProject.Fixtures.Api.Controllers
{
    [ApiController]
    public class FixtureController : ControllerBase
    {

        public FixtureStore _fixtureStore;

        public FixtureController(FixtureStore fixtureStore) 
        {
            _fixtureStore = fixtureStore;
        }

        [HttpGet]
        [Route("api/v1/[controller]")]
        public ActionResult<FixtureResponse> GetFixtures()
        {
            List<FixtureResponse> result = new List<FixtureResponse>();
            foreach(Fixture fixture in _fixtureStore.fixtureList)
            {
                FixtureResponse fixtureResponse = new FixtureResponse
                {
                    HomeTeam = fixture.HomeTeam,
                    AwayTeam = fixture.AwayTeam,
                    Stadium = fixture.Stadium,
                    KickOffTime = fixture.KickOffTime
                };

                result.Add(fixtureResponse);
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/[controller]")]
        public ActionResult<FixtureResponse> PostFixture(CreateFixtureRequest request)
        {
            Fixture fixture = new Fixture(request.HomeTeam, request.AwayTeam, request.Stadium, request.KickOffTime);

            _fixtureStore.fixtureList.Add(fixture);

            FixtureResponse result = new FixtureResponse
            {
                Id = fixture.Id,
                HomeTeam = fixture.HomeTeam,
                AwayTeam = fixture.AwayTeam,
                Stadium = fixture.Stadium,
                KickOffTime = fixture.KickOffTime
            };

            return Ok(result);
        }
    }
}
