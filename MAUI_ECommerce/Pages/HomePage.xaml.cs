using MAUI_ECommerce.PageModels;

namespace MAUI_ECommerce.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageModel homePageModel)
	{
		InitializeComponent();

        BindingContext = homePageModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is BasePageModel viewModel)
        {
            await viewModel.LoadCommand.ExecuteAsync(null);
        }
    }
}