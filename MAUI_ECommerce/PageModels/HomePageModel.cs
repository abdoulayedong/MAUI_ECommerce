using MAUI_ECommerce.DTOs;
using MAUI_ECommerce.Services;
using System.Collections.ObjectModel;

namespace MAUI_ECommerce.PageModels;

public class HomePageModel : BasePageModel
{
    private readonly IProductService _productService;
    public ObservableCollection<ProductPreviewDTO> ProductPreviews { get; set; } = new();

    public ObservableCollection<ProductPreviewDTO> FlashSaleProducts { get; set; } = new();
    public ObservableCollection<ProductPreviewDTO> MegaSaleProducts { get; set; } = new();
    public ObservableCollection<ProductPreviewDTO> RecommendedProducts { get; set; } = new();


    public HomePageModel(IProductService productService)
    {
        _productService = productService;
    }

    protected override void ClearData()
    {

    }

    protected override async Task LoadAsync(int? id = null)
    {
        var products = await _productService.GetProductPreviews();

        products.Take(3).ToList().ForEach(FlashSaleProducts.Add);
        products.TakeLast(3).ToList().ForEach(MegaSaleProducts.Add);
        products.Take(new Range(4, 6)).ToList().ForEach(RecommendedProducts.Add);
    }
}
