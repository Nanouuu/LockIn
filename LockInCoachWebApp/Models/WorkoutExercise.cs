namespace LockInCoachWebApp.Models
{
    public class WorkoutExercise
    {
        public Guid Id { get; set; }
        public Guid ExerciseId { get; set; }
        public string Notes { get; set; }

        public List<WorkoutSet> Sets { get; set; } = new();

    }
}
