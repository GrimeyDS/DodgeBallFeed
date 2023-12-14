
using Pin.LiveSports.Core.Entities.Games;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class FoulReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    { 
        public Player Player { get; set; }


        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = base.Validate(validationContext).ToList();
            if (Player is null)
                results.Add(new ValidationResult("Please select a Player."));

            return results;
        }
    }
}
