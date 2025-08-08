using Microsoft.AspNetCore.Mvc;

namespace CommunityPolling.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}