using Seller.Web.Models;
using System.Net.Http.Json;

namespace Seller.Web.Services
{
    public class SellerApiService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "http://localhost:5175/api/Seller";

        public SellerApiService()
        {
            _http = new HttpClient();
        }

        public async Task<List<InventoryDTO>> GetInventoryAsync(int sellerId)
        {
            return await _http.GetFromJsonAsync<List<InventoryDTO>>($"{_baseUrl}/inventory/{sellerId}") ?? new();
        }

        public async Task<bool> UpdateInventoryAsync(int sellerId, int blanketId, int quantity)
        {
            var res = await _http.PostAsync($"{_baseUrl}/inventory/update?sellerId={sellerId}&blanketId={blanketId}&quantity={quantity}", null);
            return res.IsSuccessStatusCode;
        }

        public async Task<List<OrderDTO>> GetOrdersAsync(string sellerName)
        {
            return await _http.GetFromJsonAsync<List<OrderDTO>>($"{_baseUrl}/orders/{sellerName}") ?? new();
        }
    }
}
