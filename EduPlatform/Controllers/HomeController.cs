using Microsoft.AspNetCore.Mvc;

namespace EduPlatform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
