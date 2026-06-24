using LockInCoachWebApp.Models;

namespace LockInCoachWebApp.Services.Interfaces
{
    public interface IAthleteService
    {
        Task<List<Athlete>> GetAllAsync();
        Task<Athlete?> GetByIdAsync(Guid id);
        Task CreateAsync(Athlete athlete);
        Task UpdateAsync(Athlete athlete);
        Task DeleteAsync(Guid id);
    }
}
