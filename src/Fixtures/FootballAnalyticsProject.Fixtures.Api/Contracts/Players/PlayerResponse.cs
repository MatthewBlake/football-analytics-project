namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Players
{
    public class PlayerResponse
    {
        public Guid Id { get; set; }

        public Guid TeamId { get; set; }

        public int ShirtNumber { get; set; }
    }
}
