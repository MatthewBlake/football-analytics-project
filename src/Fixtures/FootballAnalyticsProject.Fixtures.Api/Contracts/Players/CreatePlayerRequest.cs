namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Players
{
    public class CreatePlayerRequest
    {
        public Guid TeamId { get; set; }

        public int ShirtNumber { get; set; }
    }
}
