using System.ComponentModel.DataAnnotations;

namespace EduPlatform.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
