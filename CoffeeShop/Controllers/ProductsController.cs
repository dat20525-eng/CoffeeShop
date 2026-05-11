using CoffeeShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Shop()
        {
            return View(_repo.GetAllProducts());
        }

        public IActionResult Detail(int id)
        {
            return View(_repo.GetProductDetail(id));
        }

    }
}