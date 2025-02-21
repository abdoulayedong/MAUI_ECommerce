namespace MAUI_ECommerce.DTOs;

public class ProductPreviewDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal DiscountPercentage { get; set; }
    public decimal DiscountPrice => OriginalPrice * (1 - DiscountPercentage / 100);
}
