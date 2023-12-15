namespace Pin.LiveSports.Core.Entities.Games
{
    public class Team : BaseEntity
    {
        // Gebruik van collection expressions om te instantieren.
        public ICollection<Player> Players { get; set; } = [];
        public string LogoUrl { get; set; }
    }
}
