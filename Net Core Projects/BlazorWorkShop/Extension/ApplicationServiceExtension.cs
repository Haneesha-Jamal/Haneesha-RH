using BlazorWorkShop.DAL;
using BlazorWorkShop.Helpers;
using BlazorWorkShop.Interface;
using BlazorWorkShop.Repository;
using BlazorWorkShop.Service;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkShop.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContextPool<WorkShopDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            return services;
        }
    }
}
