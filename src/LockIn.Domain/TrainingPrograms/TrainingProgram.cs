using LockIn.Domain.Workouts;
using System.ComponentModel.DataAnnotations;

namespace LockIn.Domain.TrainingPrograms
{
    // TODO : TO REWORK 
    public class TrainingProgram
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Program name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Range(1, 52, ErrorMessage = "Number of weeks must be between 1 and 52")]
        public int NumberOfWeeks { get; set; } = 8;

        [Required(ErrorMessage = "You must select an athlete")]
        public Guid AthleteId { get; set; }

        public List<Workout> Workouts { get; set; } = new();
    }
}