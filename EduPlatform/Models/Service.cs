using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using EduPlatform.Models.ViewModels;

namespace EduPlatform.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? state { get; set; }
        [ForeignKey("Category")]
        [DisplayName("Category Name")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<OrderServiceViewModel> OrderServices { get; set; }
    }
}
