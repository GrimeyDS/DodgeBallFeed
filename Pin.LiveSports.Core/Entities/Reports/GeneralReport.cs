

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class GeneralReport : IGeneralReport
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TimeOnly Time { get; set; }
        public string ReportMessage { get; set; }

        public GeneralReport()
        {
            Id = Guid.NewGuid();
        }
    }
}
