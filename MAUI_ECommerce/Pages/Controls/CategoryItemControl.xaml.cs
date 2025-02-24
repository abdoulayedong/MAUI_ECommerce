namespace MAUI_ECommerce.Pages.Controls;

public partial class CategoryItemControl : ContentView
{
    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
    public Command TapCommand
    {
        get => (Command)GetValue(TapCommandProperty);
        set => SetValue(TapCommandProperty, value);
    }

    public static BindableProperty NameProperty = BindableProperty.Create(
        nameof(Name), typeof(string), typeof(CategoryItemControl));                

    public static BindableProperty IconProperty = BindableProperty.Create(
        nameof(Icon), typeof(string), typeof(CategoryItemControl));

    public static BindableProperty TapCommandProperty = BindableProperty.Create(
        nameof(TapCommand), typeof(Command), typeof(CategoryItemControl));
                

	public CategoryItemControl()
	{
		InitializeComponent();
        BindingContext = this;
    }
}