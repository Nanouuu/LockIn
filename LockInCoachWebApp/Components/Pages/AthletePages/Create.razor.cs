using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.AthletePages
{
    public partial class Create
    {
        [Inject]
        public IAthleteService AthleteService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [SupplyParameterFromForm]
        public Athlete? Athlete { get; set; }

        protected override void OnInitialized()
        {
            Athlete ??= new();
        }

        private async Task AddAthlete()
        {
            Console.WriteLine($"Athlete null? {Athlete == null}");

            Console.WriteLine($"FirstName: {Athlete?.FirstName}");
            Console.WriteLine($"LastName: {Athlete?.LastName}");

            await AthleteService.CreateAsync(Athlete!);
            NavigationManager.NavigateTo("/athletes");
        }
    }
}
