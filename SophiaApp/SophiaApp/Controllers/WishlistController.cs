using Microsoft.AspNetCore.Mvc;

namespace SophiaApp.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
