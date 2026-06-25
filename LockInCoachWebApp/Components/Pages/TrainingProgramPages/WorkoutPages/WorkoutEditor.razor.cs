using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.TrainingProgramPages.WorkoutPages
{
    public partial class WorkoutEditor : ComponentBase
    {
        [Parameter]
        public Guid WorkoutId { get; set; }

        [Inject]
        public ITrainingProgramService ProgramService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected Workout? workout;

        protected override async Task OnInitializedAsync()
        {
            var programs = await ProgramService.GetAllAsync();

            workout = programs
                .SelectMany(x => x.Workouts)
                .FirstOrDefault(x => x.Id == WorkoutId);
        }

        protected async Task Save()
        {
            // Quand IWorkoutService:
            // await WorkoutService.UpdateAsync(workout);

            NavigationManager.NavigateTo($"/training-programs/{workout!.TrainingProgramId}/builder");

            await Task.CompletedTask;
        }

        protected void AddExercise()
        {
            // to do : ouvrir un modal 
        }
    }
}