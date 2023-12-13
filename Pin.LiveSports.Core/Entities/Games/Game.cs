using Pin.LiveSports.Core.Entities.Reports;
using Pin.LiveSports.Core.Validators;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Games
{
    public class Game : BaseEntity, IValidatableObject
    {
        [Required]
        [Range(typeof(DateTime), "1/1/2010", "31/12/2050",
        ErrorMessage = "Date must be between 01/01/2010 and 2050")]
        public DateTime GameDate { get; set; } = DateTime.Now;

        [Required]
        public TimeOnly GameTime { get; set; }

        [Required]
        public string Location { get; set; }

        public Guid HomeTeamId { get; set; }

        public Guid AwayTeamId { get; set; }

        [Required]
        [Range(0, 100)]
        public int HomeScore { get; set; }

        [Required]
        [Range(0, 100)]
        public int AwayScore { get; set; }

        public List<GeneralReport> GeneralReports { get; set; } = new List<GeneralReport>();
        public List<FoulReport> FoulReports { get; set; } = new List<FoulReport>();
        public List<SuddenDeathReport> SuddenDeathReports { get; set; } = new List<SuddenDeathReport>();
        public List<TeamChangeReport> TeamChangeReports { get; set; } = new List<TeamChangeReport>();
        public List<ScoreReport> ScoreReports { get; set; } = new List<ScoreReport>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (HomeTeamId == Guid.Empty || AwayTeamId == Guid.Empty)
                yield return new ValidationResult("Please select a Home and Away team.");
            else
            {
                if (HomeTeamId == AwayTeamId)
                    yield return new ValidationResult("Teams cannot be the same.");
            }

        }

        public Game()
        {
            Id = Guid.NewGuid();
        }
    }
}
