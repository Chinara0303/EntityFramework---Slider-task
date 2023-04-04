using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SophiaApp.Data;
using SophiaApp.Models;

namespace SophiaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            return View(sliders);
        }
    }
}