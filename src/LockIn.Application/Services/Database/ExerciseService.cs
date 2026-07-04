using LockIn.Application.Interfaces.Services;
using LockIn.Domain.Exercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockIn.Application.Services.Database
{
    internal class ExerciseService : IExerciseService
    {
        public Task CreateAsync(Exercise exercise)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Exercise>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Exercise?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Exercise exercise)
        {
            throw new NotImplementedException();
        }
    }
}
