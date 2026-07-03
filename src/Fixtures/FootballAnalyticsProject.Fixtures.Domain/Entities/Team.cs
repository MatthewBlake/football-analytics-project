namespace FootballAnalyticsProject.Fixtures.Domain.Entities
{
    public class Team
    {
        public Team(string name, string colour) 
        {
            Id = Guid.NewGuid();
            Name = name;
            Colour = colour;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Colour { get; set; }
    }
}
