
using Pin.LiveSports.Core.Entities.Games;
using System.ComponentModel.DataAnnotations;


namespace Pin.LiveSports.Core.Entities.Reports
{
    public class TeamChangeReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    {
        public Player Player { get; set; }
        public Team Team { get; set; }

        public bool IsOut { get; set; } = false;

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = base.Validate(validationContext).ToList();
            if (Team is null)
                results.Add(new ValidationResult("Please select a Team"));
            else if (Player is null)
                results.Add(new ValidationResult("Please select a Player"));

            return results;
        }
    }
}
