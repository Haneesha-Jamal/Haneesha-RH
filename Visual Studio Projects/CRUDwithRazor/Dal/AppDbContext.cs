using CRUDwithRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDwithRazor.Dal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Product> p {  get; set; }
    }
}
