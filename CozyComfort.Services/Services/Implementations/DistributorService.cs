using AutoMapper;
using CozyComfort.Services.Data;
using CozyComfort.Services.DTOs;
using CozyComfort.Services.Models;
using CozyComfort.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CozyComfort.Services.Services.Implementations
{
    public class DistributorService : IDistributorService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DistributorService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InventoryDTO>> GetDistributorInventoryAsync(int distributorId)
        {
            var inventory = await _context.Inventories
                .Where(i => i.OwnerType == "Distributor" && i.OwnerId == distributorId)
                .Include(i => i.Blanket)
                .ToListAsync();

            return _mapper.Map<IEnumerable<InventoryDTO>>(inventory);
        }

        public async Task<bool> UpdateInventoryAsync(int distributorId, int blanketId, int quantity)
        {
            var item = await _context.Inventories
                .FirstOrDefaultAsync(i =>
                    i.OwnerType == "Distributor" &&
                    i.OwnerId == distributorId &&
                    i.BlanketId == blanketId);

            if (item == null)
            {
                item = new Inventory
                {
                    OwnerType = "Distributor",
                    OwnerId = distributorId,
                    BlanketId = blanketId,
                    Quantity = quantity
                };
                _context.Inventories.Add(item);
            }
            else
            {
                item.Quantity += quantity;
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<OrderDTO> CreateOrderAsync(OrderDTO dto)
        {
            var order = _mapper.Map<Order>(dto);
            order.Status = "Pending";

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return _mapper.Map<OrderDTO>(order);
        }

        public async Task<IEnumerable<OrderDTO>> GetOrdersBySellerNameAsync(string sellerName)
        {
            var orders = await _context.Orders
                .Where(o => o.SellerName == sellerName)
                .Include(o => o.Blanket)
                .ToListAsync();

            return _mapper.Map<IEnumerable<OrderDTO>>(orders);
        }

        public async Task<OrderDTO?> UpdateOrderStatusAsync(int orderId, string status)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null) return null;

            order.Status = status;
            await _context.SaveChangesAsync();

            return _mapper.Map<OrderDTO>(order);
        }
    }
}
