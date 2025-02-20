namespace MAUI_ECommerce.PageModels;

public class HomePageModel : BasePageModel
{
    protected override void ClearData()
    {

    }

    protected override Task LoadAsync(int? id = null)
    {
        return Task.CompletedTask;
    }
}
