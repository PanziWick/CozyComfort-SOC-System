using Distributor.Web.Models;
using Distributor.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Distributor.Web.Controllers
{
    public class InventoryController : Controller
    {
        private readonly DistributorApiService _api;

        public InventoryController(DistributorApiService api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            int distributorId = 1; // Mocked for now demo purposes
            var inventory = await _api.GetInventoryAsync(distributorId);
            return View(inventory);
        }
    }
}
