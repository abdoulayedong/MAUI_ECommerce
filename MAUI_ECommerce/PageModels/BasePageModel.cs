using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_ECommerce.PageModels;

public abstract partial class BasePageModel : ObservableObject
{
    [ObservableProperty]
    bool _isBusy;

    [RelayCommand]
    protected abstract Task LoadAsync(Nullable<int> id = null);

    protected INavigationService _navigationService;
    protected abstract void ClearData();
}
