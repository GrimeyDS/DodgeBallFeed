

using Pin.LiveSports.Core.Validators;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class GeneralReport
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [MinTimeOnlyValidator("00:01")]
        public TimeOnly Time { get; set; }

        [Required]
        public string ReportMessage { get; set; }
    }
}
