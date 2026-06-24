using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.AthletePages;

public partial class Edit : ComponentBase
{
    [Inject]
    public IAthleteService AthleteService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [SupplyParameterFromQuery]
    private Guid Id { get; set; }

    [SupplyParameterFromForm]
    private Athlete? Athlete { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Athlete ??= await AthleteService.GetByIdAsync(Id);

        if (Athlete is null)
            NavigationManager.NotFound();
    }

    private async Task UpdateAthlete()
    {
        await AthleteService.UpdateAsync(Athlete!);
        NavigationManager.NavigateTo("/athletes");
    }
}