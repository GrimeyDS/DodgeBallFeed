
using Pin.LiveSports.Core.Entities.Games;
using System.ComponentModel.DataAnnotations;


namespace Pin.LiveSports.Core.Entities.Reports
{
    // Gebruik van Prime Constructor:
    // Zet de meegegeven parameters in scope van heel de class. Hierdoor kunnen ze direct gebruikt worden voor initializering.
    // Dit verminderd lijnen code en lijkt me super interessant bij dependency injection.
    // In dit voorbeeld roept hij ook de base primary constructor op in general report.
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
