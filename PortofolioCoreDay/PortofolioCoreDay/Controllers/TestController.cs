using Microsoft.AspNetCore.Mvc;

namespace PortofolioCoreDay.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
