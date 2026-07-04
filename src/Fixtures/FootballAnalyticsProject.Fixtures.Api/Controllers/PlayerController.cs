using FootballAnalyticsProject.Fixtures.Api.Contracts.Players;
using FootballAnalyticsProject.Fixtures.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FootballAnalyticsProject.Fixtures.Api.Controllers
{
    [ApiController]
    public class PlayerController : ControllerBase
    {

        public PlayerStore _playerStore;

        public PlayerController(PlayerStore playerStore)
        {
            _playerStore = playerStore;
        }

        [HttpGet]
        [Route("api/v1/[controller]")]
        public ActionResult<List<PlayerResponse>> GetPlayers()
        {
            List<PlayerResponse> result = new List<PlayerResponse>();
            foreach (Player player in _playerStore.playerList)
            {
                PlayerResponse playerResponse = new PlayerResponse
                {
                    Id = player.Id,
                    TeamId = player.TeamId,
                    ShirtNumber = player.ShirtNumber
                };

                result.Add(playerResponse);
            }

            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/[controller]")]
        public ActionResult<PlayerResponse> PostPlayer(CreatePlayerRequest request)
        {
            Player player = new Player(request.TeamId, request.ShirtNumber);

            _playerStore.playerList.Add(player);

            PlayerResponse result = new PlayerResponse
            {
                Id = player.Id,
                TeamId = player.TeamId,
                ShirtNumber = player.ShirtNumber
            };

            return Ok(result);
        }
    }
}
