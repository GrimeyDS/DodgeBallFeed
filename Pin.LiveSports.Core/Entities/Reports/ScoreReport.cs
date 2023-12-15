using Pin.LiveSports.Core.Entities.Games;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class ScoreReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    {
        public Team ScoredTeam { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = base.Validate(validationContext).ToList();
            if (ScoredTeam is null)
                results.Add(new ValidationResult("Please select a Team."));

            return results;
        }
    }
}
