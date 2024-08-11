using AutoMapper;
using MVCcrud1.Dto;
using MVCcrud1.Models;

namespace MVCcrud1.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<StoreDto,Store>().ReverseMap();
        }
    }
}
