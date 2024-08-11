using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using MvcCrud.Dto;
using MvcCrud.Models;
using System.Runtime.InteropServices;

namespace MvcCrud.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        { 
            CreateMap<ProDto,Products>().ReverseMap();
        }
    }
}
