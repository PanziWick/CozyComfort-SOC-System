using Microsoft.AspNetCore.Mvc;
using Seller.Web.Services;

namespace Seller.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly SellerApiService _api;

        public OrdersController(SellerApiService api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            string sellerName = "SellerA"; // Mock seller name
            var orders = await _api.GetOrdersAsync(sellerName);
            return View(orders);
        }
    }
}
