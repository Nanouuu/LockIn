using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.TrainingProgramPages
{
    public partial class Create : ComponentBase
    {
        [Inject]
        public ITrainingProgramService ProgramService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected TrainingProgram model = new()
        {
            StartDate = DateTime.Today,
            NumberOfWeeks = 8
        };

        private async Task Submit()
        {
            await ProgramService.CreateAsync(model);
            NavigationManager.NavigateTo("/training-programs");
        }
    }
}
