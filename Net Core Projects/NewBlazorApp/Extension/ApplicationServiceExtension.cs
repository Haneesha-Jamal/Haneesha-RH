using Microsoft.EntityFrameworkCore;
using NewBlazorApp.DAL;
using NewBlazorApp.Helper;
using NewBlazorApp.Interface;
using NewBlazorApp.Repository;
using NewBlazorApp.Service;

namespace NewBlazorApp.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContextPool<NewDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPersonRepo, PersonRepo>();
            services.AddScoped<IPersonService,PersonService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
   
}
