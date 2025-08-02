using CozyComfort.Services.DTOs;

namespace CozyComfort.Services.Services.Interfaces
{
    public interface ISellerService
    {
        Task<IEnumerable<InventoryDTO>> GetSellerInventoryAsync(int sellerId);
        Task<bool> UpdateSellerInventoryAsync(int sellerId, int blanketId, int quantity);
        Task<IEnumerable<OrderDTO>> GetMyOrdersAsync(string sellerName);
    }
}
