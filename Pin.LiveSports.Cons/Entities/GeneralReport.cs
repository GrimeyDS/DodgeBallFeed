
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Cons.Entities
{
    // Gebruik van Prime Constructor:
    // Zet de meegegeven parameters in scope van heel de class. Hierdoor kunnen ze direct gebruikt worden voor initializering.
    // Dit verminderd lijnen code en lijkt me super interessant bij dependency injection.
    public class GeneralReport(TimeOnly currentGameTime)
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public TimeOnly Time { get; set; } = currentGameTime.AddMinutes(1);

        [Required]
        public string ReportMessage { get; set; }
    }
}
