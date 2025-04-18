using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents
{
    public class ContactComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
