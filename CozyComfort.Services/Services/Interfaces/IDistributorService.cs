using CozyComfort.Services.DTOs;

namespace CozyComfort.Services.Services.Interfaces
{
    public interface IDistributorService
    {
        Task<IEnumerable<InventoryDTO>> GetDistributorInventoryAsync(int distributorId);
        Task<bool> UpdateInventoryAsync(int distributorId, int blanketId, int quantity);
        Task<OrderDTO> CreateOrderAsync(OrderDTO dto);
        Task<IEnumerable<OrderDTO>> GetOrdersBySellerNameAsync(string sellerName);
        Task<OrderDTO?> UpdateOrderStatusAsync(int orderId, string status);
    }
}
