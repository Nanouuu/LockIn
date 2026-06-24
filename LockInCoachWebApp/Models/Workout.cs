namespace LockInCoachWebApp.Models
{
    public class Workout
    {
        public Guid Id { get; set; }

        public Guid TrainingProgramId { get; set; }

        public string Name { get; set; } = string.Empty;

        public int WeekNumber { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public bool IsRestDay { get; set; }

        public List<WorkoutExercise> Exercises { get; set; } = new();

        public DateTime GetPlannedDate(DateTime programStartDate)
        {
            return programStartDate
                .Date
                .AddDays((WeekNumber - 1) * 7)
                .AddDays((int)DayOfWeek - 1);
        }
    }
}