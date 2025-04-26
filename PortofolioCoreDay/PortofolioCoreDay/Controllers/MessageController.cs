using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;
using PortofolioCoreDay.Entities;
using PortofolioCoreDay.Models;

namespace PortofolioCoreDay.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult MessageList()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            if (ModelState.IsValid)
            {
                message.SendDate = DateTime.Now;
                message.IsRead = false;
                context.Messages.Add(message);
                await context.SaveChangesAsync();

                TempData["MessageStatus"] = "Success";
                TempData["MessageText"] = "Mesaj başarıyla gönderildi!";
                return RedirectToAction("Index", "Default");
            }

            TempData["MessageStatus"] = "Error";
            TempData["MessageText"] = "Mesaj gönderilirken bir hata oluştu!";
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
           var value = context.Messages.Find(id);
           return View(value);
        }

        [HttpPost]
        public IActionResult UpdateMessage(Message message)
        {
            if (ModelState.IsValid)
            {
                message.SendDate = DateTime.Now;
                message.IsRead = false;
                context.Messages.Update(message);
                context.SaveChanges();
                return Redirect("MessageList");
            }
            return View(message);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }
    }
}
