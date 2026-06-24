using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.ExercisePages
{
    public partial class Create : ComponentBase
    {
        [Inject]
        public IExerciseService ExerciseService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [SupplyParameterFromForm]
        protected Exercise Exercise { get; set; } = new();

        protected async Task AddExercise()
        {
            await ExerciseService.CreateAsync(Exercise);
            NavigationManager.NavigateTo("/exercises");
        }
    }
}