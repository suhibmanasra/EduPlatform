using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EduPlatform.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required]
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        

    }
}
