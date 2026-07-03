namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Teams
{
    public class TeamResponse
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Colour { get; set; }
    }
}
