using Pin.LiveSports.Core.Enumerations;

namespace Pin.LiveSports.Core.Entities.Games
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Description { get; set; } = "Awesome player that does awesome stuff";
        public string PictureUrl { get; set; }
        public bool IsOut { get; set; }
        public Role Role { get; set; }
    }
}
