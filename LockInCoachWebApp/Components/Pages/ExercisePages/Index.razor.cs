using LockInCoachWebApp.Enums;
using LockInCoachWebApp.Models;
using LockInCoachWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;

namespace LockInCoachWebApp.Components.Pages.ExercisePages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IExerciseService ExerciseService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected List<Exercise>? exerciseList;

        protected string SortOrder = "AZ";

        protected bool isDropdownOpen;

        protected HashSet<Muscle> SelectedMuscles = new();

        protected override async Task OnInitializedAsync()
        {
            await LoadExercises();
        }

        private async Task LoadExercises()
        {
            exerciseList = await ExerciseService.GetAllAsync();
        }

        protected void GoToDetails(Guid id)
        {
            NavigationManager.NavigateTo($"/exercises/details?id={id}");
        }

        protected IEnumerable<Exercise> FilteredExercises
        {
            get
            {
                if (exerciseList is null)
                    return Enumerable.Empty<Exercise>();

                IEnumerable<Exercise> query = exerciseList;

                if (SelectedMuscles.Any())
                {
                    query = query.Where(x => SelectedMuscles.Contains(x.TargetMuscle));
                }

                query = SortOrder switch
                {
                    "ZA" => query
                        .OrderBy(x => x.TargetMuscle)
                        .ThenByDescending(x => x.Name),

                    _ => query
                        .OrderBy(x => x.TargetMuscle)
                        .ThenBy(x => x.Name)
                };

                return query;
            }
        }

        protected string GetFilterLabel()
        {
            if (SelectedMuscles.Count == 0)
                return "Aucun filtre";

            if (SelectedMuscles.Count == 1)
                return $"{SelectedMuscles.First()}";

            return $"{SelectedMuscles.Count} muscles";
        }

        protected void ToggleDropdown()
        {
            isDropdownOpen = !isDropdownOpen;
        }
        protected void CloseDropdown()
        {
            isDropdownOpen = false;
        }

        protected void ToggleMuscle(Muscle muscle)
        {
            if (!SelectedMuscles.Add(muscle))
                SelectedMuscles.Remove(muscle);
        }

        protected void ClearFilters()
        {
            SelectedMuscles.Clear();
        }
    }
}