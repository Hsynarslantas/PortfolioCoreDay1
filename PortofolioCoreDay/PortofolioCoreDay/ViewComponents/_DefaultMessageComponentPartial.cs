using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;

namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultMessageComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
    }
}
