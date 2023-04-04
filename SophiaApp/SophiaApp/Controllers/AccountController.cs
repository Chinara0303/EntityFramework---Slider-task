using Microsoft.AspNetCore.Mvc;

namespace SophiaApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
