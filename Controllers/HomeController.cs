
using AllupApp.ViewModels;
using AllupApp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var featuredCategories = _dbContext.Categories.ToList().Where(x => x.isMain).ToList();

            var products = _dbContext.Products.ToList();

            var brands = _dbContext.Brands.ToList();

            var banners = _dbContext.Banners.ToList();

            var homeViewModel = new HomeViewModel
            {
                Categories = featuredCategories,
                Products = products,
                Brands = brands,
                Banners = banners
            };

            return View(homeViewModel);
        }
    }
}