namespace Pin.LiveSports.Core.Entities.Games
{
    public class Team : BaseEntity
    {
        public ICollection<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }
    }
}
