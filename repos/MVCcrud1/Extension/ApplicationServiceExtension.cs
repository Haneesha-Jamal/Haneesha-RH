using Microsoft.EntityFrameworkCore;
using MVCcrud1.Dal;
using MVCcrud1.Helper;
using MVCcrud1.Interface;
using MVCcrud1.Repository;
using MVCcrud1.Service;

namespace MVCcrud1.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddServiceApplication(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContextPool<StoreDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IStoreRepo, Repo>();
            services.AddScoped<IStoreService,Serviceee>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddControllersWithViews();
         
            return services;
        }
    }
}
