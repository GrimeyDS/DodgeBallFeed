

using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Validators
{
    public class GuidValidator : ValidationAttribute
    {

        public Guid Guid { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var guid = (Guid)value;

            if (guid == Guid.Empty)
            {
                return new ValidationResult("Please select an Team/Player");
            }

            return ValidationResult.Success;
        }
    }
}
