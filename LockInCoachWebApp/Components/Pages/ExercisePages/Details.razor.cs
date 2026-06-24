using LockInCoachWebApp.Enums;
using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.ExercisePages
{
    public partial class Details : ComponentBase
    {
        [Inject]
        public IExerciseService ExerciseService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [SupplyParameterFromQuery]
        public Guid Id { get; set; }

        protected Exercise? exercise;

        protected Exercise? exerciseToDelete;

        protected override async Task OnInitializedAsync()
        {
            exercise = await ExerciseService.GetByIdAsync(Id);

            if (exercise is null)
            {
                NavigationManager.NavigateTo("/exercises");
            }
        }
        protected void ShowConfirm()
        {
            exerciseToDelete = exercise;
        }

        protected void CancelDelete()
        {
            exerciseToDelete = null;
        }

        protected async Task DeleteExercise()
        {
            if (exerciseToDelete is not null)
            {
                await ExerciseService.DeleteAsync(exerciseToDelete.Id);
                NavigationManager.NavigateTo("/exercises");
            }
        }
    }
}