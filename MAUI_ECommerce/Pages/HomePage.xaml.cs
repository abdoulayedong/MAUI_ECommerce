using MAUI_ECommerce.PageModels;

namespace MAUI_ECommerce.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageModel homePageModel)
	{
		InitializeComponent();

        BindingContext = homePageModel;
    }
}