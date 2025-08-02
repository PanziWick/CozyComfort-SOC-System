using AutoMapper;
using CozyComfort.Services.Data;
using CozyComfort.Services.DTOs;
using CozyComfort.Services.Models;
using CozyComfort.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CozyComfort.Services.Services.Implementations
{
    public class SellerService : ISellerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SellerService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InventoryDTO>> GetSellerInventoryAsync(int sellerId)
        {
            var inventory = await _context.Inventories
                .Where(i => i.OwnerType == "Seller" && i.OwnerId == sellerId)
                .Include(i => i.Blanket)
                .ToListAsync();

            return _mapper.Map<IEnumerable<InventoryDTO>>(inventory);
        }

        public async Task<bool> UpdateSellerInventoryAsync(int sellerId, int blanketId, int quantity)
        {
            var item = await _context.Inventories
                .FirstOrDefaultAsync(i =>
                    i.OwnerType == "Seller" &&
                    i.OwnerId == sellerId &&
                    i.BlanketId == blanketId);

            if (item == null)
            {
                item = new Inventory
                {
                    OwnerType = "Seller",
                    OwnerId = sellerId,
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

        public async Task<IEnumerable<OrderDTO>> GetMyOrdersAsync(string sellerName)
        {
            var orders = await _context.Orders
                .Where(o => o.SellerName == sellerName)
                .Include(o => o.Blanket)
                .ToListAsync();

            return _mapper.Map<IEnumerable<OrderDTO>>(orders);
        }
    }
}
