using LockInCoachWebApp.Enum;
using System.ComponentModel.DataAnnotations;

namespace LockInCoachWebApp.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public List<Muscle> TargetMuscles { get; set; } = new();
    }
}
