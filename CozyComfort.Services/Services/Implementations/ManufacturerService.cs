using AutoMapper;
using CozyComfort.Services.Data;
using CozyComfort.Services.DTOs;
using CozyComfort.Services.Models;
using CozyComfort.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CozyComfort.Services.Services.Implementations
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ManufacturerService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BlanketDTO>> GetAllBlanketsAsync()
        {
            var blankets = await _context.Blankets.ToListAsync();
            return _mapper.Map<IEnumerable<BlanketDTO>>(blankets);
        }

        public async Task<BlanketDTO> GetBlanketByIdAsync(int id)
        {
            var blanket = await _context.Blankets.FindAsync(id);
            return blanket == null ? null! : _mapper.Map<BlanketDTO>(blanket);
        }

        public async Task<BlanketDTO> CreateBlanketAsync(BlanketDTO dto)
        {
            var entity = _mapper.Map<Blanket>(dto);
            _context.Blankets.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<BlanketDTO>(entity);
        }

        public async Task<BlanketDTO> UpdateBlanketAsync(int id, BlanketDTO dto)
        {
            var existing = await _context.Blankets.FindAsync(id);
            if (existing == null) return null!;

            _mapper.Map(dto, existing);
            await _context.SaveChangesAsync();
            return _mapper.Map<BlanketDTO>(existing);
        }

        public async Task<bool> DeleteBlanketAsync(int id)
        {
            var blanket = await _context.Blankets.FindAsync(id);
            if (blanket == null) return false;

            _context.Blankets.Remove(blanket);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
