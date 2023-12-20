using System.ComponentModel.DataAnnotations;
namespace PustokMVC.Models;

public class Categories
{
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public bool IsDeleted { get; set; }
    public int ParentCategoryId { get; set; }

    public IEnumerable<Product>? Products { get; set; }  



}
