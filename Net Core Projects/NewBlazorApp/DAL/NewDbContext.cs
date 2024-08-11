using Microsoft.EntityFrameworkCore;
using NewBlazorApp.Model;

namespace NewBlazorApp.DAL
{
    public class NewDbContext : DbContext
    {
        public NewDbContext() { }
        public NewDbContext(DbContextOptions<NewDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Person> persons { get; set; }
    }
}
