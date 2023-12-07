namespace Pin.LiveSports.Core.Entities.Games
{
    public class Game : BaseEntity
    {
        public DateOnly GameDate { get; set; }
        public TimeSpan GameTime { get; set; }

        public Team Home { get; set; }
        public Team Away { get; set; }
    }
}
