
using Pin.LiveSports.Core.Entities.Games;


namespace Pin.LiveSports.Core.Entities.Reports
{
    public class TeamChangeReport : GeneralReport
    {
        public Guid PlayerId { get; set; }
        public Guid TeamId { get; set; }
        public bool IsOut { get; set; } = false;
    }
}
