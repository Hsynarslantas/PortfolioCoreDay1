using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;

namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
