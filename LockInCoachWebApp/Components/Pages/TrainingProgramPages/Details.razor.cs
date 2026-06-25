using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.TrainingProgramPages;

public partial class Details
{
    [Parameter]
    public Guid ProgramId { get; set; }

    [Inject]
    public ITrainingProgramService ProgramService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    protected TrainingProgram? program;
    protected Boolean programDelete = false;

    protected readonly List<DayOfWeek> days =
    [
        DayOfWeek.Monday,
        DayOfWeek.Tuesday,
        DayOfWeek.Wednesday,
        DayOfWeek.Thursday,
        DayOfWeek.Friday,
        DayOfWeek.Saturday,
        DayOfWeek.Sunday
    ];

    protected override async Task OnInitializedAsync()
    {
        program = await ProgramService.GetByIdAsync(ProgramId);
    }

    protected void ChangeProgramDeleteStatus()
    {
        programDelete = !programDelete;
    }

    protected async Task DeleteProgram()
    {
        if (programDelete is true)
        {
            await ProgramService.DeleteAsync(program.Id);
            NavigationManager.NavigateTo("/training-programs");
        }
    }

    protected Workout? GetWorkout(int week, DayOfWeek day)
    {
        return program?.Workouts
            .FirstOrDefault(x =>
                x.WeekNumber == week &&
                x.DayOfWeek == day);
    }
}