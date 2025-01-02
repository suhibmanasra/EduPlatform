using EduPlatform.Models;
using Microsoft.AspNetCore.Identity;

namespace EduPlatform.Data
{
    public class AppUser : IdentityUser
    {

        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public appUserGender Gender { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
    public enum appUserGender
    {
        Male, Female

    }
}
