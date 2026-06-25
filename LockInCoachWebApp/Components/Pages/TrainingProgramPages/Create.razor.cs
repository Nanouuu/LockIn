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
        public IAthleteService AthleteService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        private string? error;

        protected List<Athlete> athletes = new();

        protected TrainingProgram model = new()
        {
            StartDate = DateTime.Today,
            NumberOfWeeks = 8
        };

        protected override async Task OnInitializedAsync()
        {
            athletes = await AthleteService.GetAllAsync();
        }

        private async Task Submit()
        {
            error = null;

            if (model.AthleteId == Guid.Empty)
            {
                error = "Please select an athlete.";
                return;
            }

            var programId = await ProgramService.CreateAsync(model);

            NavigationManager.NavigateTo($"/training-programs/{programId}/builder");
        }
    }
}