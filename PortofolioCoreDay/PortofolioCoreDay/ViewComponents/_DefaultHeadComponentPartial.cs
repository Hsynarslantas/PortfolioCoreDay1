using Microsoft.AspNetCore.Mvc;


namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
