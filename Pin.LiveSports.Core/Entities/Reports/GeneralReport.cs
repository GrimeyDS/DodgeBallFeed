
using Pin.LiveSports.Core.Enumerations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class GeneralReport
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ReportMessage { get; set; }
        public ReportType ReportType { get; init; } = ReportType.GeneralReport;

        public GeneralReport()
        {
            Id = Guid.NewGuid();
        }
    }
}
