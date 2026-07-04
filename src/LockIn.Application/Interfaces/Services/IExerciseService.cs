using LockIn.Domain.Exercises;

namespace LockIn.Application.Interfaces.Services
{
    public interface IExerciseService
    {
        Task<List<Exercise>> GetAllAsync();
        Task<Exercise?> GetByIdAsync(Guid id);
        Task CreateAsync(Exercise exercise);
        Task UpdateAsync(Exercise exercise);
        Task DeleteAsync(Guid id);
    }
}
