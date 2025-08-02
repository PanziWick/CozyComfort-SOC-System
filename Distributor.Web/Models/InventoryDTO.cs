namespace Distributor.Web.Models
{
    public class InventoryDTO
    {
        public int Id { get; set; }
        public string OwnerType { get; set; } = "Distributor";
        public int OwnerId { get; set; }
        public int BlanketId { get; set; }
        public int Quantity { get; set; }

        public string? BlanketModelName { get; set; }
    }
}
