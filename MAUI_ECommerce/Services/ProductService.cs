using MAUI_ECommerce.DTOs;
using MAUI_ECommerce.Repositories;

namespace MAUI_ECommerce.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<ProductPreviewDTO>> GetProductPreviews()
    {
        var products = await _repository.GetProducts();

        return products.Select(p => new ProductPreviewDTO
        {
            Name = p.Name,
            ImageUrl = p.ImageUrl,
            OriginalPrice = p.Price,
            DiscountPercentage = 24
        });
    }
}

public interface IProductService
{
    Task<IEnumerable<ProductPreviewDTO>> GetProductPreviews();
}
