using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;

namespace LockInCoachWebApp.Services.Stubs
{
    public class AthleteServiceStub : IAthleteService
    {
        private readonly List<Athlete> _athletes = new()
        {
            new Athlete
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@mail.com",
                PhoneNumber = "0600000001"
            },
            new Athlete
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                FirstName = "Emma",
                LastName = "Smith",
                Email = "emma.smith@mail.com",
                PhoneNumber = "0600000002"
            },
            new Athlete
            {
                Id = Guid.NewGuid(),
                FirstName = "Lucas",
                LastName = "Martin",
                Email = "lucas.martin@mail.com",
                PhoneNumber = "0600000003"
            }
        };

        public Task<List<Athlete>> GetAllAsync()
        {
            return Task.FromResult(_athletes);
        }

        public Task<Athlete?> GetByIdAsync(Guid id)
        {
            var athlete = _athletes.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(athlete);
        }

        public Task CreateAsync(Athlete athlete)
        {
            athlete.Id = Guid.NewGuid();
            _athletes.Add(athlete);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Athlete athlete)
        {
            var existing = _athletes.FirstOrDefault(x => x.Id == athlete.Id);

            if (existing != null)
            {
                existing.FirstName = athlete.FirstName;
                existing.LastName = athlete.LastName;
                existing.Email = athlete.Email;
                existing.PhoneNumber = athlete.PhoneNumber;
            }

            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            var athlete = _athletes.FirstOrDefault(x => x.Id == id);

            if (athlete != null)
            {
                _athletes.Remove(athlete);
            }

            return Task.CompletedTask;
        }
    }
}