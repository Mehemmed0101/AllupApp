
using AllupApp.ViewModels;
using AllupApp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Allup.Controllers
{
    public class ShopController : Controller
    {
        public readonly AppDbContext _dbContext;

        public ShopController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();
            var brands = _dbContext.Brands.ToList();
            var banners = _dbContext.Banners.ToList();

            var shopViewModel = new ShopViewModel
            {
                Products = products,
                Brands = brands,
                Banners = banners
            };

            return View(shopViewModel);
        }
    }
}
