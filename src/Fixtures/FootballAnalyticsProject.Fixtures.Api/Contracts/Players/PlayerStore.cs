using FootballAnalyticsProject.Fixtures.Domain.Entities;

namespace FootballAnalyticsProject.Fixtures.Api.Contracts.Players
{
    public class PlayerStore
    {
        public PlayerStore()
        {
            playerList = new List<Player>();
        }

        public List<Player> playerList { get; set; }
    }
}
