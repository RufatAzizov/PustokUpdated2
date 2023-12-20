using PustokMVC.Contexts;
using PustokMVC.ViewModels.BasketVM;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Cryptography.Xml;
namespace PustokMVC.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {
        PustokDbContext _context { get; }

        public BasketViewComponent(PustokDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = JsonConvert.DeserializeObject<List<BasketProductAndCountVM>>(HttpContext.Request.Cookies["basket"] ?? "[]");
            var products = _context.Products.Where(p => items.Select(i => i.Id).Contains(p.Id));
            List<BasketProductItemVM> basketItems = new();
            foreach (var item in products)
            {
                basketItems.Add(new BasketProductItemVM
                {
                    Id = item.Id,
                    Discount = item.Discount,
                    ImageUrl = item.ImageUrl,
                    Title = item.Title,
                    Price = item.SellPrice,
                    Count = items.FirstOrDefault(x => x.Id == item.Id).Count
                });
            }
            return View(basketItems);
        }
    }
}
