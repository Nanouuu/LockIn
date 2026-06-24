using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.AthletePages;

public partial class Index : ComponentBase
{
    [Inject]
    public IAthleteService AthleteService { get; set; } = default!;

    protected IQueryable<Athlete>? athleteList;
    protected Athlete? athleteToDelete;

    private List<Athlete> allAthletes = new();

    protected string searchText = "";
    protected string sortOrder = "AZ";

    protected override async Task OnInitializedAsync()
    {
        await LoadAthletes();
    }

    private async Task LoadAthletes()
    {
        var list = await AthleteService.GetAllAsync();
        allAthletes = list.ToList();
        athleteList = allAthletes.AsQueryable();
    }

    // 🔎 + ↕️ FILTER + SORT
    protected IQueryable<Athlete> FilteredAthletes
    {
        get
        {
            IEnumerable<Athlete> query = allAthletes;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = query.Where(a =>
                    ($"{a.FirstName} {a.LastName}")
                    .Contains(searchText, StringComparison.OrdinalIgnoreCase));
            }

            query = sortOrder == "AZ"
                ? query.OrderBy(a => a.FirstName).ThenBy(a => a.LastName)
                : query.OrderByDescending(a => a.FirstName).ThenByDescending(a => a.LastName);

            return query.AsQueryable();
        }
    }

    protected void ShowConfirm(Athlete a)
    {
        athleteToDelete = a;
    }

    protected async Task DeleteAthlete()
    {
        if (athleteToDelete is not null)
            await AthleteService.DeleteAsync(athleteToDelete.Id);

        athleteToDelete = null;
        await LoadAthletes();
    }

    protected void CancelDelete()
    {
        athleteToDelete = null;
    }
}