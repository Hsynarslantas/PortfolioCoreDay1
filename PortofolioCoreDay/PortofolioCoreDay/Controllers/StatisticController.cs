using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;

namespace PortofolioCoreDay.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x=>x.SkillValue);
            ViewBag.v3= context.Skills.Average(x=>x.SkillValue);
            ViewBag.v4=context.Skills.Where(x=>x.SkillValue > 80).Count();
            ViewBag.v5 = context.Skills.Max(x => x.SkillValue);
            ViewBag.v7 = context.Skills.Where(x => x.SkillValue < 50).Count(); 
            ViewBag.v8 = context.Skills.Where(x => x.SkillValue >= 90).Average(x => x.SkillValue); 
            ViewBag.v9 = context.Skills.OrderByDescending(x => x.SkillValue).FirstOrDefault()?.SkillName; 
            ViewBag.v10 = context.Skills.OrderBy(x => x.SkillValue).FirstOrDefault()?.SkillName;
            return View();
        }
    }
}
