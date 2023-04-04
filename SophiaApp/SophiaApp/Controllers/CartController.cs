using Microsoft.AspNetCore.Mvc;

namespace SophiaApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
