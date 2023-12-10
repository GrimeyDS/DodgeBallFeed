using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Enumerations;


namespace Pin.LiveSports.Core.Entities.Reports
{
    public class SuddenDeathReport : GeneralReport
    {
        public Player HomePlayer { get; set; }
        public Player AwayPlayer { get; set; }

        public SuddenDeathReport()
        {
            ReportType = ReportType.SuddenDeathReport;
        }
    }
}
