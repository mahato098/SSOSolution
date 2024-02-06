using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectB.ViewModel
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "Passwords does not match.")]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;

        [DataType(DataType.MultilineText)]
        public string Address { get; set; } = string.Empty;
    }
}
