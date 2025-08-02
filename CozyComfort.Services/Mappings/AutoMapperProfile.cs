using AutoMapper;
using CozyComfort.Services.Models;
using CozyComfort.Services.DTOs;
namespace CozyComfort.Services.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Blanket, BlanketDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Inventory, InventoryDTO>().ReverseMap();
        }
    }
}
