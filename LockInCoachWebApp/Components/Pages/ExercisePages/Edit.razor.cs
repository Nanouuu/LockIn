using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.ExercisePages
{
    public partial class Edit : ComponentBase
    {
        [SupplyParameterFromQuery]
        public Guid Id { get; set; }

        [Inject]
        public IExerciseService ExerciseService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected Exercise? exercise;

        protected override async Task OnInitializedAsync()
        {
            exercise = await ExerciseService.GetByIdAsync(Id);

            if (exercise is null)
            {
                NavigationManager.NavigateTo("/not-found");
            }
        }

        protected async Task SaveAsync()
        {
            if (exercise is null)
                return;

            await ExerciseService.UpdateAsync(exercise);

            NavigationManager.NavigateTo("/exercises");
        }
    }
}