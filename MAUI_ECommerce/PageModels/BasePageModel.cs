using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_ECommerce.Services;

namespace MAUI_ECommerce.PageModels;

public abstract partial class BasePageModel : ObservableObject
{
    [ObservableProperty]
    private bool _isBusy;

    [RelayCommand]
    protected abstract Task LoadAsync(Nullable<int> id = default);

    // Initialisation avec default! pour indiquer à l'analyseur que l'injection se fera ultérieurement.
    protected readonly INavigationService _navigationService = default!;

    protected abstract void ClearData();
}
