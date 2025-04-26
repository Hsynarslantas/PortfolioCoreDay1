using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;

namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultSkillComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
