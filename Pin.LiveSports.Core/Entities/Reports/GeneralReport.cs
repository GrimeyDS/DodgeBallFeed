

using Pin.LiveSports.Core.Validators;
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities.Reports
{
    public class GeneralReport(TimeOnly currentGameTime) : IValidatableObject
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [MinTimeOnlyValidator("00:01")]
        public TimeOnly Time { get; set; } = currentGameTime;

        [Required]
        public string ReportMessage { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Time <= currentGameTime)
                yield return new ValidationResult("Time cannot be less than the current game time.");
        }
    }
}
