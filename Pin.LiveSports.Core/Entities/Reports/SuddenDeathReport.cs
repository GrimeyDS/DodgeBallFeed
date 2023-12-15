

using Pin.LiveSports.Core.Entities.Games;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    // Gebruik van Prime Constructor:
    // Zet de meegegeven parameters in scope van heel de class. Hierdoor kunnen ze direct gebruikt worden voor initializering.
    // Dit verminderd lijnen code en lijkt me super interessant bij dependency injection.
    // In dit voorbeeld roept hij ook de base primary constructor op in general report.
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
