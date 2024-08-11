
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi
{
    public static class AppicationServiceExtension 
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContextPool<BrandDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;

        }
        
    }
}
