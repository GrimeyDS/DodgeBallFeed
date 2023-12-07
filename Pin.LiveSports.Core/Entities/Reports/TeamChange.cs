
using Pin.LiveSports.Core.Entities.Games;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class TeamChange : Report
    {
        public Player Player { get; set; }
        public Team Team { get; set; }
        public bool IsOut {  get; set; }
    }
}
