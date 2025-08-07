using Distributor.Web.Models;
using Distributor.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Distributor.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly DistributorApiService _api;

        public OrdersController(DistributorApiService api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            string sellerName = "SellerA"; // Mocked for demo purposes
            var orders = await _api.GetOrdersAsync(sellerName);
            return View(orders);
        }

        public IActionResult Create()
        {
            return View(new OrderDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderDTO order)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid input data.");
                return View(order);
            }

            bool success = await _api.CreateOrderAsync(order);

            if (success)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Failed to create order.");
            return View(order);
        }

        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            bool result = await _api.UpdateOrderStatusAsync(id, status);
            return RedirectToAction("Index");
        }
    }
}
