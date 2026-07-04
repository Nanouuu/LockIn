namespace LockIn.Domain.Workouts
{
    public class WorkoutExercise
    {
        public Guid Id { get; set; }

        public Guid ExerciseId { get; set; }

        public string Notes { get; set; } = string.Empty;

        public List<WorkoutSet> Sets { get; set; } = new();
    }
}