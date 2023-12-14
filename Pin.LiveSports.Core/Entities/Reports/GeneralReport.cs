
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class GeneralReport(TimeOnly currentGameTime) : IValidatableObject
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public TimeOnly Time { get; set; } = currentGameTime.AddMinutes(1);

        [Required]
        public string ReportMessage { get; set; }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (Time <= currentGameTime)
                results.Add(new ValidationResult("Time cannot be less than the current game time."));

            return results;
        }
    }
}
