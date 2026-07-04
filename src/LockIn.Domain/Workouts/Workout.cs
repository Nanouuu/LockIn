namespace LockIn.Domain.Workouts
{
    public class Workout
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<WorkoutExercise> Exercises { get; set; } = new();
    }
}