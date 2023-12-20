using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Contexts;
using PustokMVC.ViewModels.SliderVM;

namespace PustokMVC.ViewComponents
{
    public class HeroSliderViewComponent : ViewComponent
    {
        PustokDbContext _context;
        public HeroSliderViewComponent(PustokDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View(await _context.HeroSliders.Select(s => new SliderListVM
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                Price = s.Price,
                ImageURL = s.ImageURL,
                IsRight = s.IsRight,

            }).ToListAsync()); 
        }
    }
}
