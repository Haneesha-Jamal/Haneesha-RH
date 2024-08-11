using JWTActivity.DAL;
using Microsoft.EntityFrameworkCore;

namespace JWTActivity.Extension
{
    public static class ApplicationServiceException
    {
      public static IServiceCollection AddServiceException(this IServiceCollection services,IConfiguration config)
       {
            services.AddDbContextPool<UserDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            return services;

       }
    }
}
