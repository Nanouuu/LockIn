using LockInCoachWebApp.DTO;
using LockInCoachWebApp.Factories;
using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.TrainingProgramPages;

public partial class Index : ComponentBase
{
    [Inject] 
    public ITrainingProgramService ProgramService { get; set; } = default!;
    [Inject] 
    public IAthleteService AthleteService { get; set; } = default!;
    [Inject] 
    public NavigationManager NavigationManager { get; set; } = default!;

    protected List<Athlete> athletes = new();

    protected List<TrainingProgramListItem>? programs;
    protected List<TrainingProgramListItem>? programsFiltered;

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

    protected override async Task OnInitializedAsync()
    {
        athletes = await AthleteService.GetAllAsync();

        var rawPrograms = await ProgramService.GetAllAsync();

        var athleteDict = athletes.ToDictionary(x => x.Id);

        programs = rawPrograms
            .Select(p => TrainingProgramFactory.Create(p, athleteDict))
            .ToList();

        ApplyFilter();
    }

    protected void ApplyFilter()
    {
        if (programs is null)
            return;

        programsFiltered =
            SelectedAthleteId is null || SelectedAthleteId == Guid.Empty
                ? programs
                : programs.Where(x => x.AthleteId == SelectedAthleteId).ToList();
    }

    protected DateTime GetEndDate(TrainingProgramListItem p)
        => p.EndDate;

    protected void OpenProgram(Guid id)
    {
        NavigationManager.NavigateTo($"/training-programs/{id}");
    }
}