namespace CozyComfort.Services.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public int BlanketId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}
