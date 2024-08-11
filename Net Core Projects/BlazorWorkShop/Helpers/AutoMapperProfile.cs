using AutoMapper;
using BlazorWorkShop.Dto;
using BlazorWorkShop.Models;

namespace BlazorWorkShop.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserProfileDto, User>().ReverseMap();
            CreateMap<InterviewDto, Interview>().ReverseMap();
            CreateMap<CompanyDto, Company>().ReverseMap();
            CreateMap<JobDto, Jobs>().ReverseMap();
        }
    }
}
