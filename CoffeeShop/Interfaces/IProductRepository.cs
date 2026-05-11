using CoffeeShop.Models;

namespace CoffeeShop.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductDetail(int id);
    }
}