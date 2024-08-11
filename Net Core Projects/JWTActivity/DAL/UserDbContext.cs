using JWTActivity.Model;
using Microsoft.EntityFrameworkCore;

namespace JWTActivity.DAL
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> userss { get; set; }
    }
}
