using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.TrainingProgramPages.WorkoutPages
{
    public partial class WorkoutEditor : ComponentBase
    {
        [Parameter]
        public Guid WorkoutId { get; set; }

        [SupplyParameterFromQuery]
        public Guid ProgramId { get; set; }

        [Inject]
        public ITrainingProgramService ProgramService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected Workout? workout;
        protected TrainingProgram? program;

        protected bool showExerciseModal;

        protected override async Task OnInitializedAsync()
        {
            program = await ProgramService.GetByIdAsync(ProgramId);

            workout = program?.Workouts.FirstOrDefault(x => x.Id == WorkoutId);
        }

        protected async Task Save()
        {
            if (program is null)
                return;

            await ProgramService.UpdateAsync(program);

            NavigationManager.NavigateTo($"/training-programs/{program.Id}/builder");
        }

        protected void AddExercise()
        {
            showExerciseModal = true;
        }

        protected void CloseExerciseModal()
        {
            showExerciseModal = false;
        }

        protected void AddExerciseToWorkout(Exercise exercise)
        {
            if (workout is null)
                return;

            workout.Exercises.Add(new WorkoutExercise
            {
                Id = Guid.NewGuid(),
                ExerciseId = exercise.Id,
                ExerciseName = exercise.Name,
                Notes = string.Empty,
                Sets =
                [
                    new WorkoutSet
                    {
                        Id = Guid.NewGuid(),
                        SetNumber = 1,
                        Reps = 10,
                        Weight = 0,
                        RestTime = 90
                    }
                ]
            });

            showExerciseModal = false;
        }
    }
}