namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Teams
{
    public class CreateTeamRequest
    {
        public required string Name { get; set; }

        public required string Colour { get; set; }
    }
}
