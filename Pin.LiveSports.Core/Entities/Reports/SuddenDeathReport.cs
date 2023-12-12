

using Pin.LiveSports.Core.Validators;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class SuddenDeathReport : GeneralReport
    {
        [GuidValidator]
        public Guid HomePlayerId { get; set; }
        [GuidValidator]
        public Guid AwayPlayerId { get; set; }

    }
}
