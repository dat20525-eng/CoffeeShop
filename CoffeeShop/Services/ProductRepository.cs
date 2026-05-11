using CoffeeShop.Data;
using CoffeeShop.Interfaces;
using CoffeeShop.Models;

namespace CoffeeShop.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeeShopDbContext _context;

        public ProductRepository(CoffeeShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product? GetProductDetail(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}