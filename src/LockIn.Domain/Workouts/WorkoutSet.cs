namespace LockIn.Domain.Workouts
{
    public class WorkoutSet
    {
        public Guid Id { get; set; }

        public int SetNumber { get; set; }

        public int Reps { get; set; }

        public decimal Weight { get; set; }

        public int RestTime { get; set; }
    }
}