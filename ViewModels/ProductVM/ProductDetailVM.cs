using PustokMVC.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PustokMVC.ViewModels.ProductVM
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SellPrice { get; set; }
        public float Discount { get; set; }
        public ushort Quantity { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<string> ImageUrls { get; set; }
        public Categories? Category { get; set; }
        public string Description { get; set; }
    }
}
