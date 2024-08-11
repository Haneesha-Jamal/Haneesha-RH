using Microsoft.EntityFrameworkCore;
using MvcCrud.DAL;
using MvcCrud.Helper;
using MvcCrud.Interface;
using MvcCrud.Repository;
using MvcCrud.Service;

namespace MvcCrud.Extension
{
    public static  class ApplicationServiceExtension
    {
        public static IServiceCollection AddServiceExtension(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContextPool<PersonDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IRepo, Repo>();
            services.AddScoped<IService, ServiceFunction>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            return services;
        }
    }
}
