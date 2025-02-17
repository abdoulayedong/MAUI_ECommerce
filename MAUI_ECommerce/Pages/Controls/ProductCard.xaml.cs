namespace MAUI_ECommerce.Pages.Controls;

public partial class ProductCard : ContentView
{
    public static BindableProperty ProductNameProperty = BindableProperty.Create(
        nameof(ProductName), typeof(string), typeof(ProductCard));

    public static BindableProperty ImageSourceProperty = BindableProperty.Create(
        nameof(ImageSource), typeof(string), typeof(ProductCard));

    public static BindableProperty CurrentPriceProperty = BindableProperty.Create(
        nameof(CurrentPrice), typeof(string), typeof(ProductCard));

    public static BindableProperty OriginalPriceProperty = BindableProperty.Create(
        nameof(OriginalPrice), typeof(string), typeof(ProductCard));

    public static readonly BindableProperty DiscountProperty = BindableProperty.Create(
        nameof(Discount), typeof(string), typeof(ProductCard), string.Empty);

    public string ImageSource
    {
        get => (string)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }

    public string ProductName
    {
        get => (string)GetValue(ProductNameProperty);
        set => SetValue(ProductNameProperty, value);
    }

    public string CurrentPrice
    {
        get => (string)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }

    public string OriginalPrice
    {
        get => (string)GetValue(ProductNameProperty);
        set => SetValue(ProductNameProperty, value);
    }
    public string Discount
    {
        get => (string)GetValue(DiscountProperty);
        set => SetValue(DiscountProperty, value);
    }


    public ProductCard()
	{
		InitializeComponent();
        BindingContext = this;
	}
}