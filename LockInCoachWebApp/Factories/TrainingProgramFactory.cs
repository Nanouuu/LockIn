using LockInCoachWebApp.DTO;
using LockInCoachWebApp.Models;

namespace LockInCoachWebApp.Factories
{
    public static class TrainingProgramFactory
    {
        public static TrainingProgramListItem Create(
            TrainingProgram p,
            Dictionary<Guid, Athlete> athletes)
        {
            var endDate = p.StartDate.AddDays(p.NumberOfWeeks * 7 - 1);

            return new TrainingProgramListItem
            {
                Id = p.Id,
                Name = p.Name,
                StartDate = p.StartDate,
                NumberOfWeeks = p.NumberOfWeeks,
                EndDate = endDate,
                AthleteId = p.AthleteId,

                AthleteName =
                    p.AthleteId is Guid id &&
                    athletes.TryGetValue(id, out var athlete)
                        ? $"{athlete.FirstName} {athlete.LastName}"
                        : "Unknown"
            };
        }
    }
}
