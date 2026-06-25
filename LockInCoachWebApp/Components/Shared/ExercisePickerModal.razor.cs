using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Shared
{
    public partial class ExercisePickerModal
    {
        [Inject]
        public IExerciseService ExerciseService { get; set; } = default!;

        [Parameter]
        public bool IsVisible { get; set; }

        [Parameter]
        public EventCallback OnClose { get; set; }

        [Parameter]
        public EventCallback<Exercise> OnSelect { get; set; }

        protected List<Exercise> exercises = [];

        protected string search = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            exercises = await ExerciseService.GetAllAsync();
        }

        protected IEnumerable<Exercise> FilteredExercises =>
            exercises.Where(x =>
                string.IsNullOrWhiteSpace(search)
                || x.Name.Contains(search,
                    StringComparison.OrdinalIgnoreCase));

        protected async Task SelectExercise(Exercise exercise)
        {
            await OnSelect.InvokeAsync(exercise);
        }

        protected async Task Close()
        {
            await OnClose.InvokeAsync();
        }
    }
}