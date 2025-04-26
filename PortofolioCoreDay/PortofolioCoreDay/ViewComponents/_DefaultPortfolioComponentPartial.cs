using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;

namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
          var values=context.Categories.ToList();
            return View(values);
        }
    }
}
