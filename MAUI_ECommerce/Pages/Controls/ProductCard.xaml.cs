namespace MAUI_ECommerce.Pages.Controls;

public partial class ProductCard : ContentView
{
    public static readonly BindableProperty ImageWidthRequestProperty = BindableProperty.Create(
       nameof(ImageWidthRequest), typeof(double), typeof(ProductCard));

    public static readonly BindableProperty ImageHeightRequestProperty = BindableProperty.Create(
        nameof(ImageHeightRequest), typeof(double), typeof(ProductCard));

    public static readonly new BindableProperty WidthRequestProperty = BindableProperty.Create(
        nameof(WidthRequest), typeof(double), typeof(ProductCard));

    public static readonly new BindableProperty HeightRequestProperty = BindableProperty.Create(
        nameof(HeightRequest), typeof(double), typeof(ProductCard));

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
        get => (string)GetValue(CurrentPriceProperty);
        set => SetValue(CurrentPriceProperty, value);
    }

    public string OriginalPrice
    {
        get => (string)GetValue(OriginalPriceProperty);
        set => SetValue(OriginalPriceProperty, value);
    }
    public string Discount
    {
        get => (string)GetValue(DiscountProperty);
        set => SetValue(DiscountProperty, value);
    }

    public new double WidthRequest
    {
        get => (double)GetValue(WidthRequestProperty);
        set => SetValue(WidthRequestProperty, value);
    }
    public new double HeightRequest
    {
        get => (double)GetValue(HeightRequestProperty);
        set => SetValue(HeightRequestProperty, value);
    }

    public double ImageWidthRequest
    {
        get => (double)GetValue(ImageWidthRequestProperty);
        set => SetValue(ImageWidthRequestProperty, value);
    }
    public double ImageHeightRequest
    {
        get => (double)GetValue(ImageHeightRequestProperty);
        set => SetValue(ImageHeightRequestProperty, value);
    }

    public ProductCard()
	{
		InitializeComponent();
        BindingContext = this;
	}
}