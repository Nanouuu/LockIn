using LockInCoachWebApp.Models;

namespace LockInCoachWebApp.Services.Interfaces
{

    public interface ITrainingProgramService
    {
        Task<List<TrainingProgram>> GetAllAsync();
        Task<TrainingProgram?> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(TrainingProgram program); 
        Task UpdateAsync(TrainingProgram program);
        Task DeleteAsync(Guid id);
        Task<Workout?> GetWorkoutAsync(Guid workoutId);
    }
}
