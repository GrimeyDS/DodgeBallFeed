using Pin.LiveSports.Core.Entities.Reports;
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

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        [Required]
        [Range(0, 100)]
        public int HomeScore { get; set; }

        [Required]
        [Range(0, 100)]
        public int AwayScore { get; set; }

        public ICollection<GeneralReport> GeneralReports { get; set; } = new List<GeneralReport>();
        public ICollection<FoulReport> FoulReports { get; set; } = new List<FoulReport>();
        public ICollection<SuddenDeathReport> SuddenDeathReports { get; set; } = new List<SuddenDeathReport>();
        public ICollection<TeamChangeReport> TeamChangeReports { get; set; } = new List<TeamChangeReport>();
        public ICollection<ScoreReport> ScoreReports { get; set; } = new List<ScoreReport>();
        public ICollection<WinReport> WinReports { get; set; } = new List<WinReport>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(HomeTeam is null || AwayTeam is null)
                yield return new ValidationResult("Please select a Home and Away team.");
            else
            {
                if (HomeTeam.Id == Guid.Empty || AwayTeam.Id == Guid.Empty)
                    yield return new ValidationResult("Please select a Home and Away team.");
                else
                {
                    if (HomeTeam.Id == AwayTeam.Id)
                        yield return new ValidationResult("Teams cannot be the same.");
                }
            }
        }

        public Game()
        {
            Id = Guid.NewGuid();
        }
    }
}
