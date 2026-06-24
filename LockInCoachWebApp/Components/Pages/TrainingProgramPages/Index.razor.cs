using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.TrainingProgramPages;

public partial class Index : ComponentBase
{
    [Inject]
    public ITrainingProgramService ProgramService { get; set; } = default!;

    // TEMP stub 
    protected List<Athlete> athletes = new()
    {
        new Athlete { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), FirstName = "John", LastName = "Doe" },
        new Athlete { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), FirstName = "Mike", LastName = "Smith" }
    };

    private Guid? _selectedAthleteId;
    protected Guid? SelectedAthleteId
    {
        get => _selectedAthleteId;
        set
        {
            _selectedAthleteId = value;
            ApplyFilter();
        }
    }

    protected List<TrainingProgram>? programs;
    protected List<TrainingProgram>? programsFiltered;

    protected override async Task OnInitializedAsync()
    {
        programs = await ProgramService.GetAllAsync();
        ApplyFilter();
    }

    protected void ApplyFilter()
    {
        if (programs is null)
            return;

        programsFiltered = SelectedAthleteId is null || SelectedAthleteId == Guid.Empty
            ? programs
            : programs.Where(x => x.AthleteId == SelectedAthleteId).ToList();
    }

    protected DateTime GetEndDate(TrainingProgram p)
    {
        return p.StartDate.AddDays((p.NumberOfWeeks * 7) - 1);
    }

}