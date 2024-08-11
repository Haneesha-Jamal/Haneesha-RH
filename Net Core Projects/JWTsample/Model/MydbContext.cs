using Microsoft.EntityFrameworkCore;

namespace JWTsample.Model
{
    public class MydbContext : DbContext
    {
        public MydbContext(DbContextOptions<MydbContext> options)
             : base(options)
        {
        }

        public DbSet<User> users { get; set; }
    }
}
