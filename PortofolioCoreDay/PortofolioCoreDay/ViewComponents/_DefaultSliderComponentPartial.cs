using Microsoft.AspNetCore.Mvc;

namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
