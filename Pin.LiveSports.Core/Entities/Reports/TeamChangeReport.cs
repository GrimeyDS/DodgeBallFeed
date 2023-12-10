
using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Enumerations;


namespace Pin.LiveSports.Core.Entities.Reports
{
    public class TeamChangeReport : GeneralReport
    {
        public Player Player { get; set; }
        public Team Team { get; set; }
        public bool IsOut {  get; set; }

        public TeamChangeReport()
        {
            ReportType = ReportType.TeamChangeReport;
        }
    }
}
