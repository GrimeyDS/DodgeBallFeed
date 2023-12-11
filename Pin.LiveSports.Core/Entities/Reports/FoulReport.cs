
using Pin.LiveSports.Core.Validators;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class FoulReport : GeneralReport
    {
        [GuidValidator]
        public Guid PlayerId { get; set; }

    }
}
