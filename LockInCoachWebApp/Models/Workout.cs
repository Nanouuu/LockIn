namespace LockInCoachWebApp.Models
{
    public class Workout
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime PlannedDate { get; set; }
        public List<WorkoutExercise> Exercises { get; set; } = new();
    }
}
