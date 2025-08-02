using Microsoft.AspNetCore.Mvc;
using Seller.Web.Services;

namespace Seller.Web.Controllers
{
    public class InventoryController : Controller
    {
        private readonly SellerApiService _api;

        public InventoryController(SellerApiService api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            int sellerId = 1; // Mocked seller ID
            var inventory = await _api.GetInventoryAsync(sellerId);
            return View(inventory);
        }
    }
}
