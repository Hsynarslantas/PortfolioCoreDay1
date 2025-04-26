using Microsoft.AspNetCore.Mvc;

namespace PortofolioCoreDay.ViewComponents
{
    public class _DefaultSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    
}
}
