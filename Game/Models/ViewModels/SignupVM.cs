using System.ComponentModel.DataAnnotations;

namespace GameShop.Models.ViewModels
{
    public class SignupVM
    {
        [Required(ErrorMessage = "This field is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        [MinLength(8, ErrorMessage = "This field must be at least 8 characters long")]
        [MaxLength(40, ErrorMessage = "This field must be a maximum of 40 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        [Compare("Password", ErrorMessage = "'Repeat Password' and 'Password' do not match.")]
        public string RepeatPassword { get; set; }
    }
}
