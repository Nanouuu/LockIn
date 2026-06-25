using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Components.Shared;

public partial class ConfirmModal : ComponentBase
{
    [Parameter] public string Message { get; set; } = string.Empty;
    [Parameter] public string ActionTitle { get; set; } = string.Empty;
    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }


    private async Task HandleConfirm() => await OnConfirm.InvokeAsync();
    private async Task HandleCancel() => await OnCancel.InvokeAsync();
}