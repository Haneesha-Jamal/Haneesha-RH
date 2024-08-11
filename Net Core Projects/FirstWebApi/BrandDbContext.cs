using Microsoft.EntityFrameworkCore;

namespace FirstWebApi
{
    public class BrandDbContext : DbContext
    {
        public BrandDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Brand> brands { get; set; }
    }
}
