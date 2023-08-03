using AllupApp.ViewModels;
using AllupApp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Allup.Controllers
{
    public class ContactController : Controller
    {
        public readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var contacts = _dbContext.Contacts.ToList();
            var brands = _dbContext.Brands.ToList();
            var banners = _dbContext.Banners.ToList();

            var contactViewModel = new ContactViewModel
            {
                Contacts = contacts,
                Brands = brands,
                Banners = banners
            };

            return View(contactViewModel);
        }
    }
}