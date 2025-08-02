namespace CozyComfort.Services.DTOs
{
    public class InventoryDTO
    {
        public int Id { get; set; }
        public string OwnerType { get; set; }
        public int OwnerId { get; set; }
        public int BlanketId { get; set; }
        public int Quantity { get; set; }
    }
}
