using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace PustokMVC.Models
{
    public class HeroSlider
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(30)]
        public string Title { get; set; }
        [ MinLength(3), MaxLength(30)]
        public string? Description { get; set; }
        [Required, Column(TypeName ="smallmoney")]
        public decimal Price { get; set; }
        [Required]
        public string ImageURL { get; set; }
        public bool IsRight { get; set; }   
    }
}
