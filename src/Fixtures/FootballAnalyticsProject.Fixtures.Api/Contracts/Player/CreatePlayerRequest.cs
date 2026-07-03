namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Player
{
    public class CreatePlayerRequest
    {
        public Guid TeamId { get; set; }

        public int ShirtNumber { get; set; }
    }
}
