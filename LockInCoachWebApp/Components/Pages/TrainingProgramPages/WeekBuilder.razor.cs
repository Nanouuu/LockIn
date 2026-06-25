using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Pages.TrainingProgramPages
{
    public partial class WeekBuilder : ComponentBase
    {
        [Parameter]
        public Guid ProgramId { get; set; }

        [Inject]
        public ITrainingProgramService ProgramService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected bool showRestDayConfirm;
        protected DayOfWeek? pendingRestDay;

        protected TrainingProgram? program;

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

        protected Workout? GetWorkout(DayOfWeek day)
        {
            return program?.Workouts
                .FirstOrDefault(x =>
                    x.WeekNumber == 1 &&
                    x.DayOfWeek == day);
        }

        private Workout GetOrCreateWorkout(DayOfWeek day)
        {
            var existing = GetWorkout(day);

            if (existing is not null)
                return existing;

            var workout = new Workout
            {
                Id = Guid.NewGuid(),
                TrainingProgramId = program!.Id,
                WeekNumber = 1,
                DayOfWeek = day,
                Name = "",
                IsRestDay = false
            };

            program.Workouts.Add(workout);


            return workout;
        }


        protected void SetWorkout(DayOfWeek day)
        {
            var workout = GetOrCreateWorkout(day);

            workout.IsRestDay = false;

            workout.Name = $"{day} Workout";
        }

        protected void SetRestDay(DayOfWeek day)
        {
            var workout = GetOrCreateWorkout(day);

            workout.IsRestDay = true;
            workout.Name = "Rest Day";
        }

        protected void AskSetRestDay(DayOfWeek day)
        {
            pendingRestDay = day;
            showRestDayConfirm = true;
        }

        protected void ConfirmSetRestDay()
        {
            if (pendingRestDay is null)
                return;

            SetRestDay(pendingRestDay.Value);

            showRestDayConfirm = false;
            pendingRestDay = null;
        }

        protected void CancelRestDay()
        {
            showRestDayConfirm = false;
            pendingRestDay = null;
        }

        protected void EditWorkout(Guid workoutId)
        {
            NavigationManager.NavigateTo(
                $"/training-programs/workouts/{workoutId}?programId={program.Id}");
        }


        // =========================
        // FUTURE FEATURE
        // =========================

        protected async Task ApplyWeekTemplate()
        {
            if (program is null)
                return;

            // TODO : lors de la save, duplicate sur les autres semaines

            await Task.CompletedTask;
        }
    }
}