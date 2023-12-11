
using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Enumerations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class FoulReport : GeneralReport
    {
        public Player Player { get; set; }

        public FoulReport()
        {
            Player = new Player();
        }
    }
}
