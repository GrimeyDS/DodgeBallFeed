
using Pin.LiveSports.Core.Validators;


namespace Pin.LiveSports.Core.Entities.Reports
{
    public class TeamChangeReport : GeneralReport
    {
        [GuidValidator]
        public Guid PlayerId { get; set; }
        [GuidValidator]
        public Guid TeamId { get; set; }
        public bool IsOut { get; set; } = false;
    }
}
