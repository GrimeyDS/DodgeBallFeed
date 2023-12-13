
using Pin.LiveSports.Core.Validators;
using System.ComponentModel.DataAnnotations;


namespace Pin.LiveSports.Core.Entities.Reports
{
    public class TeamChangeReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    {
        [GuidValidator]
        public Guid PlayerId { get; set; }
        [GuidValidator]
        public Guid TeamId { get; set; }
        public bool IsOut { get; set; } = false;
    }
}
