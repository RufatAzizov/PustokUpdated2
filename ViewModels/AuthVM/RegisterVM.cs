using System.ComponentModel.DataAnnotations;

namespace PustokMVC.ViewModels.AuthVM
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please enter your fullname!"), MaxLength(40)]
        public string Fullname { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your username"), MaxLength(24)]
        public string Username { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(ConfirmPassword)), RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{4,}$", ErrorMessage = "Wrong input for password")]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{4,}$", ErrorMessage = "Wrong input for password")]
        public string ConfirmPassword { get; set; }
    }
}