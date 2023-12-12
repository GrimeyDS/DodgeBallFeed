
using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Validators
{
    public class MinTimeOnlyValidator : ValidationAttribute
    {
        private readonly TimeOnly _minValue;

        public MinTimeOnlyValidator(string minValue)
        {
            if (!TimeOnly.TryParse(minValue, out _minValue))
            {
                throw new ArgumentException("Invalid time format for minValue.");
            }
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is TimeOnly timeValue)
            {
                if (timeValue < _minValue)
                {
                    return new ValidationResult($"The field {validationContext.DisplayName} must be greater than or equal to {_minValue}.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
