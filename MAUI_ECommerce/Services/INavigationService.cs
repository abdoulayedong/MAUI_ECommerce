namespace MAUI_ECommerce.Services;

public interface INavigationService
{
    Task NavigateToAsync(string route, Dictionary<string, object> param);
    Task GoBackAsync(bool isAnimated = true);
    Task GoToRootAsync(bool isAnimated = true);
}

public class NavigationService : INavigationService
{
    public Task GoBackAsync(bool isAnimated)
    {
        return Shell.Current.Navigation.PopAsync(isAnimated);
    }

    public Task GoToRootAsync(bool isAnimated = true)
    {
        return Shell.Current.Navigation.PopToRootAsync(isAnimated);
    }

    public Task NavigateToAsync(string route, Dictionary<string, object> param)
    {
        if (param?.Count > 0)
        {
            return Shell.Current.GoToAsync(route, param);
        }

        return Shell.Current.GoToAsync(route);
    }
}