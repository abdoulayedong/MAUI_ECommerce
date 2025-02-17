using MAUI_ECommerce.PageModels;

namespace MAUI_ECommerce.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterPageModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}