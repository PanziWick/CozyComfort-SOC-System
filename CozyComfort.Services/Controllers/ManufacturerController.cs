using CozyComfort.Services.DTOs;
using CozyComfort.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CozyComfort.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _service;

        public ManufacturerController(IManufacturerService service)
        {
            _service = service;
        }

        [HttpGet("blankets")]
        public async Task<IActionResult> GetAll() =>
            Ok(await _service.GetAllBlanketsAsync());

        [HttpGet("blankets/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetBlanketByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost("blankets")]
        public async Task<IActionResult> Create([FromBody] BlanketDTO dto) =>
            Ok(await _service.CreateBlanketAsync(dto));

        [HttpPut("blankets/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] BlanketDTO dto)
        {
            var result = await _service.UpdateBlanketAsync(id, dto);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("blankets/{id}")]
        public async Task<IActionResult> Delete(int id) =>
            Ok(await _service.DeleteBlanketAsync(id));
    }
}
