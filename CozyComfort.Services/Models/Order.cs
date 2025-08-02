namespace CozyComfort.Services.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string SellerName { get; set; } // Seller name or ID
        public int BlanketId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } // Pending, Approved, Shipped, Delivered

        public Blanket? Blanket { get; set; }
    }
}
