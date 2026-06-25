using LockInCoachWebApp.Models;

namespace LockInCoachWebApp.Services.Interfaces
{
    public interface IWorkoutService
    {
        Task<Workout?> GetByIdAsync(Guid id);
        Task<List<Workout>> GetAllAsync();

        Task CreateAsync(Workout workout);
        Task UpdateAsync(Workout workout);
        Task DeleteAsync(Guid id);
    }
}