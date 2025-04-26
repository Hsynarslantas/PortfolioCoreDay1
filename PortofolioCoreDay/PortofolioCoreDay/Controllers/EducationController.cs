using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PortofolioCoreDay.Context;
using PortofolioCoreDay.Entities;

namespace PortofolioCoreDay.Controllers
{
    public class EducationController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult EducationList()
        {
            var value=context.Educations.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var value = context.Educations.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            context.Educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult DeleteEducation(int id) 
        {
            var values=context.Educations.Find(id);
            context.Educations.Remove(values);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
