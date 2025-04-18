using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class SkillComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            MyPortfolioContext portfolioContext = new MyPortfolioContext();
            var values = portfolioContext.Skills.ToList();

            return View(values);
        }
    }
}
