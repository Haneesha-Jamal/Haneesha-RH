using AutoMapper;
using NewBlazorApp.Dto;
using NewBlazorApp.Model;

namespace NewBlazorApp.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<PersonDto,Person>().ReverseMap();
        }
    }
}
