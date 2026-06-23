namespace LockInCoachWebApp.Models
{
    public class WorkoutSet
    {
        public Guid Id { get; set; }

        public int setNumber { get; set; }
        public int Reps { get; set; }
        public decimal Weight { get; set; }
        public int RestTime { get; set; } // in seconds
    }
}
