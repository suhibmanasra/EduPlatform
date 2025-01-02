using EduPlatform.Data;
using EduPlatform.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace EduPlatform.Models
{
    public class Order
    {
        public int OrderId { get; set; }
    
        public int OrderStateId { get; set; }
        public OrderState OrderState { get; set; }
        public string? OrderDescription { get; set; }
        public DateTime OrderDate { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }  // العلاقة
        public ICollection<OrderServiceViewModel> OrderServices { get; set; }




    }

    
}
