using System;
using AutoMapper;
using BlazorExercise.Dtos;
 using BlazorExercise.Models;

namespace BlazorExercise.Helpers
{
	public class AutoMapperProfile: Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<UserDto, User>().ReverseMap();
			CreateMap<UserProfileDto, User>().ReverseMap();
			CreateMap<InterviewDto, Interview>().ReverseMap();
			CreateMap<CompanyDto, Company>().ReverseMap();
			CreateMap<JobDto, Job>().ReverseMap();
		}
	}
}

