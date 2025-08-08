using Microsoft.AspNetCore.Mvc;

namespace CommunityPolling.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}