using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Contexts;
using PustokMVC.Models;
using PustokMVC.ViewModels.SliderVM;

namespace PustokMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        PustokDbContext _context;
        public SliderController(PustokDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            var list = await _context.HeroSliders.Select(c => new SliderListVM
            {
                Title = c.Title,
                Description = c.Description,
                Id = c.Id,
                ImageURL = c.ImageURL,
                IsRight = c.IsRight,
                Price = c.Price,
            }).ToListAsync();
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(HeroSlider vm)
        {
            
            if (!ModelState.IsValid )
            {
                return View(vm);
            }
            
            await _context.HeroSliders.AddAsync(vm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
