using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace MvcCrud.Models
{
    public class ProDBContext : DbContext
    {
        public ProDBContext() { }
        public ProDBContext(DbContextOptions<ProDBContext> options):base(options) { }

        public virtual DbSet<Products> products { get; set; }



    }
}
