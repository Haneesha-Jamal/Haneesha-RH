using DomainDAL.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDAL.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApiWorkShopDbcontext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("APIWorkshop")));
            return services;
        }
    }
}
