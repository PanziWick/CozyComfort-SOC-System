namespace CozyComfort.Services.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string OwnerType { get; set; } // Manufacturer, Distributor, Seller
        public int OwnerId { get; set; }      // ID of the entity (e.g., DistributorID)
        public int BlanketId { get; set; }
        public int Quantity { get; set; }

        public Blanket? Blanket { get; set; }
    }
}
