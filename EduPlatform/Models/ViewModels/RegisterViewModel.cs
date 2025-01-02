using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EduPlatform.Data;

namespace EduPlatform.Models.ViewModels
{
    public class RegisterViewModel : AppUser
    {
        

        [EmailAddress]
        [Required]
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and confirm not match")]
        public string ConfirmPassword { get; set; }
   
      

    }
}
