
using Pin.LiveSports.Core.Validators;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class FoulReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    { 
        [GuidValidator]
        public Guid PlayerId { get; set; }
    }
}
