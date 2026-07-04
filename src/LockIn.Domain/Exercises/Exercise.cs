using LockIn.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace LockIn.Domain.Exercises
{
    public class Exercise
    {
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public HashSet<MuscleGroup> TargetMuscle { get; set; } = new();
    }
}
