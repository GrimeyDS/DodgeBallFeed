using Pin.LiveSports.Core.Entities.Games;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class SuddenDeathReport : Report
    {
        public Player HomePlayer { get; set; }
        public Player AwayPlayer { get; set; }
    }
}
