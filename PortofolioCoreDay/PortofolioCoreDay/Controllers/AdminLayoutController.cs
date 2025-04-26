using Microsoft.AspNetCore.Mvc;

namespace PortofolioCoreDay.Controllers
{
    public class AdminLayoutController : Controller
    {
        public PartialViewResult PartialHead() 
        {
            return PartialView();
         }
        public PartialViewResult PartialSideBarTopMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
