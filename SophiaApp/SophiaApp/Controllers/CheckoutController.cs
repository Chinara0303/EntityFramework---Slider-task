using Microsoft.AspNetCore.Mvc;

namespace SophiaApp.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
