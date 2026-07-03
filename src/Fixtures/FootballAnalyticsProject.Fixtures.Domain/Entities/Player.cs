using System;
using System.Collections.Generic;
using System.Text;

namespace FootballAnalyticsProject.Fixtures.Domain.Entities
{
    public class Player
    {

        public Player(Guid teamId, int shirtNumber)
        {
            Id = Guid.NewGuid();
            TeamId = teamId;
            ShirtNumber = shirtNumber;
        }

        public Guid Id { get; set; }

        public Guid TeamId { get; set; }

        public int ShirtNumber { get; set; }
    }
}
