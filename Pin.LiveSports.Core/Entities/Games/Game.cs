using Pin.LiveSports.Core.Entities.Reports;
using Pin.LiveSports.Core.Validators;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Games
{
    public class Game : BaseEntity
    {
        [Required]
        [Range(typeof(DateTime), "1/1/2010", "31/12/2050",
        ErrorMessage = "Date must be between 01/01/2010 and now")]
        public DateTime GameDate { get; set; }
        [Required]
        public DateTime GameTime { get; set; }
        [Required]
        public string Location { get; set; }
        [GuidValidator]
        public Guid HomeTeamId { get; set; }
        [GuidValidator]
        public Guid AwayTeamId { get; set; }
        [Required]
        [Range(0, 100)]
        public int HomeScore { get; set; }
        [Required]
        [Range(0, 100)]
        public int AwayScore { get; set; }

        public int counter { get; set; }

        public List<GeneralReport> GeneralReports { get; set; }
        public List<FoulReport> FoulReports { get; set; }
        public List<SuddenDeathReport> SuddenDeathReports { get; set; }
        public List<TeamChangeReport> TeamChangeReports { get; set; }
        public List<ScoreReport> ScoreReports { get; set; }

        public Game()
        {
            GeneralReports = new List<GeneralReport>();
            FoulReports = new List<FoulReport>();
            SuddenDeathReports = new List<SuddenDeathReport>();
            TeamChangeReports = new List<TeamChangeReport>();
            ScoreReports = new List<ScoreReport>();
        }
    }
}
