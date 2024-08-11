using System;
using BlazorExercise.Models;
using BlazorExercise.Repository;
using BlazorExercise.Services;
using Microsoft.EntityFrameworkCore;
using BlazorExercise.Helpers;
using BlazorExercise.Interface;


namespace BlazorExercise.Extensions
{
	public static class ApplicationServiceExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContextPool<HireMeNowDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IUserService, UserService>();
			services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            return services;
		}
	}
}

