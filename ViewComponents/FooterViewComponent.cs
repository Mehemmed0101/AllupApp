
using AllupApp.ViewModels;
using AllupApp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Allup.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var footer = _dbContext.Footer.Include(x => x.AboutUs).Include(x => x.Customers).Include(x => x.Details).Include(x => x.Information).Include(x => x.Message).Include(x => x.MyAccounts).Include(x => x.Payments).FirstOrDefault();

            return View(footer);
        }
    }
}