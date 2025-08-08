using Microsoft.AspNetCore.Mvc;
using CommunityPolling.Models;
using System.Collections.Generic;

namespace CommunityPolling.Controllers
{
    public class FeedbackController : Controller
    {
        
        private static readonly List<Feedback> _feedbacks = new List<Feedback>();

        [HttpGet]
        public IActionResult Index()
        {
            
            ViewBag.Recent = _feedbacks;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(Feedback model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Recent = _feedbacks;
                return View("Index", model);
            }

            
            model.Id = _feedbacks.Count + 1;
            _feedbacks.Add(model);

            TempData["Success"] = "Thanks for your feedback!";
            return RedirectToAction("Index");
        }
    }
}