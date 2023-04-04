using Microsoft.AspNetCore.Mvc;

namespace SophiaApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
