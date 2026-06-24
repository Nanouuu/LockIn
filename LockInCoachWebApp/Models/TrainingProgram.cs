namespace LockInCoachWebApp.Models
{
    public class TrainingProgram
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public int NumberOfWeeks { get; set; } = 8;

        public Guid AthleteId { get; set; }

        public Athlete? Athlete { get; set; }

        public List<Workout> Workouts { get; set; } = new();
    }
}