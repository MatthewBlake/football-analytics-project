using FootballAnalyticsProject.Fixtures.Domain.Entities;

namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Teams
{
    public class TeamStore
    {
        public TeamStore()
        {
            teamList = new List<Team>();
        }

        public List<Team> teamList { get; set; }
    }
}
