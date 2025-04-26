using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;

namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultMyProjectComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
