using Microsoft.EntityFrameworkCore;
using MvcCrud.Models;

namespace MvcCrud.Extension
{
    public static class ApplicationServiceExtension 
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services , IConfiguration config) 
        {

            services.AddDbContextPool<ProDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
