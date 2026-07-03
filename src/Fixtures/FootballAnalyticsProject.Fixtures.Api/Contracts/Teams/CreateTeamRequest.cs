namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Teams
{
    public class CreateTeamRequest
    {
        public required string TeamName { get; set; }

        public required string TeamColour { get; set; }
    }
}
