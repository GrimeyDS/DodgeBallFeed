using Pin.LiveSports.Core.Entities.Games;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class WinReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    {
        public Team WinningTeam { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = base.Validate(validationContext).ToList();
            if (WinningTeam is null)
                results.Add(new ValidationResult("Please select a Team."));

            return results;
        }
    }
}