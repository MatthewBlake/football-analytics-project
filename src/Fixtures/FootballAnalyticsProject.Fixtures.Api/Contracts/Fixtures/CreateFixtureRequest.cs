using FootballAnalyticsProject.Fixtures.Domain.Entities;

namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Fixtures
{
    public class CreateFixtureRequest
    {
        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public string Stadium { get; set; }

        public DateTime KickOffTime { get; set; }
    }
}
