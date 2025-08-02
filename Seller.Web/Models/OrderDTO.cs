namespace Seller.Web.Models
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string OrderSource { get; set; } = string.Empty; // Seller Name
        public int BlanketId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } = "Pending";
        public string? BlanketModelName { get; set; }
    }
}
