using System.ComponentModel.DataAnnotations;

namespace Distributor.Web.Models
{
    public class OrderDTO
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Seller Name")]
        public string SellerName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Blanket ID")]
        public int BlanketId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        public string Status { get; set; } = "Pending";

        public string? BlanketModelName { get; set; }
    }
}
