

using Pin.LiveSports.Core.Entities.Games;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class SuddenDeathReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    {
        public Player HomePlayer { get; set; }
        public Player AwayPlayer { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = base.Validate(validationContext).ToList();
            if (HomePlayer is null || AwayPlayer is null)
                results.Add(new ValidationResult("Please select both players."));

            return results;
        }
    }
}
