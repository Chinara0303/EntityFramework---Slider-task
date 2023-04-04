using Microsoft.AspNetCore.Mvc;

namespace SophiaApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
