using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LockInCoachWebApp.Services.Local
{
    public class AthleteLocalService : IAthleteService
    {
        private readonly LockInCoachWebAppContext _db;

        public AthleteLocalService(LockInCoachWebAppContext db)
        {
            _db = db;
        }

        public async Task<List<Athlete>> GetAllAsync()
            => await _db.Athletes.ToListAsync();

        public async Task<Athlete?> GetByIdAsync(Guid id)
            => await _db.Athletes.FindAsync(id);

        public async Task CreateAsync(Athlete athlete)
        {
            _db.Athletes.Add(athlete);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Athlete athlete)
        {
            _db.Athletes.Update(athlete);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var athlete = await _db.Athletes.FindAsync(id);

            if (athlete is null)
                return;

            _db.Athletes.Remove(athlete);
            await _db.SaveChangesAsync();
        }
    }
}
