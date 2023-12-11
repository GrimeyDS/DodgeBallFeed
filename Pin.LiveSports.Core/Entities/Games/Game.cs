using Pin.LiveSports.Core.Entities.Reports;
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
        [Required]
        public Guid HomeTeamId { get; set; }
        [Required]
        public Guid AwayTeamId { get; set; }
        [Required]
        public int HomeScore { get; set; }
        [Required]
        public int AwayScore { get; set; } 

        public List<GeneralReport> GeneralReports { get; set; }
        public List<FoulReport> FoulReports { get; set; }
        public List<SuddenDeathReport> SuddenDeathReports { get; set; }
        public List<TeamChangeReport> TeamChangeReports { get; set; }

    }
}
