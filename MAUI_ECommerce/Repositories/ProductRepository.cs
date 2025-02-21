using MAUI_ECommerce.Models;

namespace MAUI_ECommerce.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Nike air max 270 react",
                ImageUrl = "nikeair.png",
                Description = "",
                Price = 170000
            },
            new Product
            {
                Id = 2,
                Name = "Chevron Quilted Satchel Bag",
                ImageUrl = "fsquiltedmaxi.png",
                Description = "",
                Price = 100000
            },
            new Product
            {
                Id = 3,
                Name = "Nike React Infinity Run Flyknit",
                ImageUrl = "nikeairmax.png",
                Description = "",
                Price = 192000
            },
            new Product
            {
                Id = 4,
                Name = "Shamriz Bag",
                ImageUrl = "bagred.png",
                Description = "",
                Price = 0
            },
            new Product
            {
                Id = 5,
                Name = "Nike Air Max 270 React Blue",
                ImageUrl = "nikeairmulticolor.png",
                Description = "",
                Price = 0
            },
            new Product
            {
                Id = 6,
                Name = "Zara Puffy Green Cinch Tote Shoulder Bag",
                ImageUrl = "baggreen.png",
                Description = "",
                Price = 0
            },
            new Product
            {
                Id = 7,
                Name = "Nike Air Zoom Pegasus 36 Miami",
                ImageUrl = "nikeairblue.png",
                Description = "",
                Price = 0
            },
            new Product
            {
                Id = 8,
                Name = "GLITZIES - Across body bag",
                ImageUrl = "baggold.png",
                Description = "",
                Price = 0
            }
        };

        public Task<Product?> GetProductById(int id) =>
            Task.FromResult(_products.FirstOrDefault(x => x.Id == id));

        public Task<IEnumerable<Product>> GetProducts() => 
            Task.FromResult(_products.AsEnumerable());
    }

    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product?> GetProductById(int id);
    }
}
