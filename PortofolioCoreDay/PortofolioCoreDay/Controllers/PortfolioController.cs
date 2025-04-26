using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using PortofolioCoreDay.Context;
using PortofolioCoreDay.Entities;

namespace PortofolioCoreDay.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult ProjectList()
        {
            var values=context.Portfolios.Include(x=>x.Category).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            var values = new SelectList(context.Categories.ToList(),"CategoryId","CategoryName");
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio) 
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = context.Portfolios.Find(id);
            ViewBag.v = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName", values.CategoryId);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = context.Portfolios.Find(id);
            context.Portfolios.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}
