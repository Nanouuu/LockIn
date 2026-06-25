namespace LockInCoachWebApp.DTO
{
    public class TrainingProgramListItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid? AthleteId { get; set; }
        public string AthleteName { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }
        public int NumberOfWeeks { get; set; }

        public DateTime EndDate { get; set; }
    }
}
