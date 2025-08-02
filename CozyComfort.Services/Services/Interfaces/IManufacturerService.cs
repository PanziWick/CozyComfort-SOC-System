using CozyComfort.Services.DTOs;

namespace CozyComfort.Services.Services.Interfaces
{
    public interface IManufacturerService
    {
        Task<IEnumerable<BlanketDTO>> GetAllBlanketsAsync();
        Task<BlanketDTO> GetBlanketByIdAsync(int id);
        Task<BlanketDTO> CreateBlanketAsync(BlanketDTO dto);
        Task<BlanketDTO> UpdateBlanketAsync(int id, BlanketDTO dto);
        Task<bool> DeleteBlanketAsync(int id);
    }
}
