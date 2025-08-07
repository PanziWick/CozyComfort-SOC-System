using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Manufacturer.Desktop.Models;
using System.Net.Http.Json;

namespace Manufacturer.Desktop.Services
{
    internal class BlanketService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "http://localhost:8080/api/Manufacturer";

        public BlanketService()
        {
            _http = new HttpClient();
        }

        public async Task<List<BlanketDTO>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<BlanketDTO>>($"{_baseUrl}/blankets") ?? new();
        }

        public async Task<BlanketDTO?> GetByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<BlanketDTO>($"{_baseUrl}/blankets/{id}");
        }

        public async Task<bool> CreateAsync(BlanketDTO dto)
        {
            var res = await _http.PostAsJsonAsync($"{_baseUrl}/blankets", dto);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id, BlanketDTO dto)
        {
            var res = await _http.PutAsJsonAsync($"{_baseUrl}/blankets/{id}", dto);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var res = await _http.DeleteAsync($"{_baseUrl}/blankets/{id}");
            return res.IsSuccessStatusCode;
        }
    }
}
