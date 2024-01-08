
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Cons.Entities
{
    public class Game
    {
        [Required]
        public TimeOnly GameTime { get; set; } = new TimeOnly();

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        // Gebruik van collection expressions om te instantieren.
        public ICollection<GeneralReport> GeneralReports { get; set; } = [];
        public ICollection<FoulReport> FoulReports { get; set; } = [];
    }
}
