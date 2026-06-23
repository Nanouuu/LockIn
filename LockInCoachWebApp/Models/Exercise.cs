using LockInCoachWebApp.Enums;
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
        public Muscle TargetMuscle { get; set; }
    }
}
