using PustokMVC.ViewModels.ProductVM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(64)]
        public string Title { get; set; }
        [Required, MinLength(3), MaxLength(30)]
        public string Description { get; set; }
        [Required, MinLength(3), MaxLength(40)]
        public bool IsDeleted { get; set; }
        public float Discount { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal ActualPrice { get; set; }
        [Required, Column(TypeName ="smallmoney")]
        public decimal SellPrice { get; set; }
        [Required]
        public int ProductCode { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
        public ushort Quantity { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }



    }
}
