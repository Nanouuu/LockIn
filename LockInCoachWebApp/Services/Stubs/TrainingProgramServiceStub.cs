using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;

namespace LockInCoachWebApp.Services.Stubs
{
    public class TrainingProgramServiceStub : ITrainingProgramService
    {
        private readonly List<TrainingProgram> _programs = new();
        
        public TrainingProgramServiceStub()
        {
            _programs.Add(new TrainingProgram
            {
                Id = Guid.NewGuid(),
                Name = "Hypertrophy Block",
                StartDate = DateTime.Today.AddDays(-14),
                NumberOfWeeks = 8,
                AthleteId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Workouts = new()
            });

            _programs.Add(new TrainingProgram
            {
                Id = Guid.NewGuid(),
                Name = "Strength Cycle",
                StartDate = DateTime.Today,
                NumberOfWeeks = 6,
                AthleteId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Workouts = new()
            });
        }


        public Task<List<TrainingProgram>> GetAllAsync()
            => Task.FromResult(_programs);

        public Task<TrainingProgram?> GetByIdAsync(Guid id)
            => Task.FromResult(_programs.FirstOrDefault(x => x.Id == id));

        public Task<Guid> CreateAsync(TrainingProgram program)
        {
            program.Id = Guid.NewGuid();

            program.Workouts ??= new();

            _programs.Add(program);

            return Task.FromResult(program.Id);
        }

        public Task DeleteAsync(Guid id)
        {
            var exercise = _programs.FirstOrDefault(x => x.Id == id);
            if (exercise != null)
                _programs.Remove(exercise);

            return Task.CompletedTask;
        }
    }
}
