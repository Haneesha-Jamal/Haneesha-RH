using AutoMapper;
using MvcCrud.Dto;
using MvcCrud.Models;

namespace MvcCrud.Helper
{
    public class AutoMapperProfile : Profile
    {
        

        public AutoMapperProfile()
        {
            CreateMap<PersonDto, Person>().ReverseMap();
        }
    }
}
;