using CommunityToolkit.Mvvm.Input;
using MauiExample.Models;

namespace MauiExample.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}