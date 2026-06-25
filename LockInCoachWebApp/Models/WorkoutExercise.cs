namespace LockInCoachWebApp.Models
{
    public class WorkoutExercise
    {
        public Guid Id { get; set; }

        public Guid WorkoutId { get; set; }

        public Guid ExerciseId { get; set; }

        public string? ExerciseName { get; set; }

        public string Notes { get; set; } = string.Empty;

        public Exercise? Exercise { get; set; }

        public List<WorkoutSet> Sets { get; set; } = new();
    }
}