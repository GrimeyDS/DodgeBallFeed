using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Enumerations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class FullGameReport : GeneralReport
    {
        public Game Game { get; set; }

        public FullGameReport()
        {
            Game = new Game();
            ReportType = ReportType.FullGameReport;
        }
    }
}
