using Distributor.Web.Models;
using System.Net.Http.Json;

namespace Distributor.Web.Services
{
    public class DistributorApiService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "http://localhost:8080/api/Distributor";

        public DistributorApiService()
        {
            _http = new HttpClient();
        }

        public async Task<List<InventoryDTO>> GetInventoryAsync(int distributorId)
        {
            return await _http.GetFromJsonAsync<List<InventoryDTO>>($"{_baseUrl}/inventory/{distributorId}") ?? new();
        }

        public async Task<bool> UpdateInventoryAsync(int distributorId, int blanketId, int quantity)
        {
            var response = await _http.PostAsync($"{_baseUrl}/inventory/update?distributorId={distributorId}&blanketId={blanketId}&quantity={quantity}", null);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<OrderDTO>> GetOrdersAsync(string sellerName)
        {
            return await _http.GetFromJsonAsync<List<OrderDTO>>($"{_baseUrl}/orders/{sellerName}") ?? new();
        }

        public async Task<bool> CreateOrderAsync(OrderDTO order)
        {
            var response = await _http.PostAsJsonAsync($"{_baseUrl}/orders", order);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Order creation failed: {response.StatusCode} - {error}");
            }

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateOrderStatusAsync(int orderId, string newStatus)
        {
            var response = await _http.PutAsync($"{_baseUrl}/orders/{orderId}/status?status={newStatus}", null);
            return response.IsSuccessStatusCode;
        }
    }
}
