using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Contexts;

namespace PustokMVC.Controllers
{
    public class HomeController : Controller
    {
        PustokDbContext _context;
        public HomeController(PustokDbContext context)
        {
            _context = context;
        }
        public string GetCookie(string key)
        {
            return HttpContext.Request.Cookies[key] ?? "";
        }
        public IActionResult GetBasket()
        {
            return ViewComponent("Basket");
        }
        public async Task<IActionResult>  Index()
        {
            var sliders = await _context.HeroSliders.ToListAsync();
            return View(sliders);
        }
    }
}