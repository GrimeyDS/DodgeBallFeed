
namespace Pin.LiveSports.Cons.Entities
{
    // Gebruik van Prime Constructor:
    // Zet de meegegeven parameters in scope van heel de class. Hierdoor kunnen ze direct gebruikt worden voor initializering.
    // Dit verminderd lijnen code en lijkt me super interessant bij dependency injection.
    // In dit voorbeeld roept hij ook de base primary constructor op in general report.
    public class FoulReport(TimeOnly currentGameTime) : GeneralReport(currentGameTime)
    { 
        public string Player { get; set; }
    }
}
