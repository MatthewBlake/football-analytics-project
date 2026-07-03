namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Player
{
    public class PlayerResponse
    {
        public Guid Id { get; set; }

        public Guid TeamId { get; set; }

        public int ShirtNumber { get; set; }
    }
}
