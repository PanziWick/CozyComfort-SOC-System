using CozyComfort.Services.DTOs;
using CozyComfort.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CozyComfort.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistributorController : ControllerBase
    {
        private readonly IDistributorService _service;

        public DistributorController(IDistributorService service)
        {
            _service = service;
        }

        [HttpGet("inventory/{distributorId}")]
        public async Task<IActionResult> GetInventory(int distributorId) =>
            Ok(await _service.GetDistributorInventoryAsync(distributorId));

        [HttpPost("inventory/update")]
        public async Task<IActionResult> UpdateInventory([FromQuery] int distributorId, [FromQuery] int blanketId, [FromQuery] int quantity)
        {
            var result = await _service.UpdateInventoryAsync(distributorId, blanketId, quantity);
            return result ? Ok() : BadRequest();
        }

        [HttpPost("orders")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDTO dto) =>
            Ok(await _service.CreateOrderAsync(dto));

        [HttpGet("orders/{sellerName}")]
        public async Task<IActionResult> GetOrders(string sellerName) =>
            Ok(await _service.GetOrdersBySellerNameAsync(sellerName));

        [HttpPut("orders/{orderId}/status")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, [FromQuery] string status)
        {
            var updated = await _service.UpdateOrderStatusAsync(orderId, status);
            return updated == null ? NotFound() : Ok(updated);
        }
    }
}
