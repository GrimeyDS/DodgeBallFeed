

using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
