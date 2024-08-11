using JWTsample.Model;
using Microsoft.EntityFrameworkCore;

namespace JWTsample.Extension
{
    public static  class ApplicationServiceException
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<MydbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            return services;

        }
    }
}
