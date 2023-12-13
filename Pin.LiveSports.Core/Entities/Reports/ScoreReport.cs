using Pin.LiveSports.Core.Validators;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class ScoreReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    {
        [GuidValidator]
        public Guid ScoredTeam { get; set; }
    }
}
