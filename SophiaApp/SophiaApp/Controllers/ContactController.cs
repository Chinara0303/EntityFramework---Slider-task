using Microsoft.AspNetCore.Mvc;

namespace SophiaApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
