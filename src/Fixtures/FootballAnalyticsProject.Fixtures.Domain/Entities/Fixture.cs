namespace FootballAnalyticsProject.Fixtures.Domain.Entities
{
    public class Fixture
    {

        public Fixture(Team homeTeam, Team awayTeam, string stadium, DateTime kickOffTime) 
        {
            Id = Guid.NewGuid();
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Stadium = stadium;
            KickOffTime = kickOffTime;
        }
        public Guid Id { get; set; }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public string Stadium { get; set; }

        public DateTime KickOffTime { get; set; }
    }
}
