using CozyComfort.Services.DTOs;
using CozyComfort.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CozyComfort.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _service;

        public SellerController(ISellerService service)
        {
            _service = service;
        }

        [HttpGet("inventory/{sellerId}")]
        public async Task<IActionResult> GetInventory(int sellerId) =>
            Ok(await _service.GetSellerInventoryAsync(sellerId));

        [HttpPost("inventory/update")]
        public async Task<IActionResult> UpdateInventory([FromQuery] int sellerId, [FromQuery] int blanketId, [FromQuery] int quantity)
        {
            var result = await _service.UpdateSellerInventoryAsync(sellerId, blanketId, quantity);
            return result ? Ok() : BadRequest();
        }

        [HttpGet("orders/{sellerName}")]
        public async Task<IActionResult> GetMyOrders(string sellerName) =>
            Ok(await _service.GetMyOrdersAsync(sellerName));
    }
}
