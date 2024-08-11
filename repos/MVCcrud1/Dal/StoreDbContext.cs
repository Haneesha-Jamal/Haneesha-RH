using Microsoft.EntityFrameworkCore;
using MVCcrud1.Models;
using MVCcrud1.Dto;

namespace MVCcrud1.Dal
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() { }
        
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public virtual DbSet<Store> Stores { get; set; }
        public DbSet<MVCcrud1.Dto.StoreDto> StoreDto { get; set; } = default!;
    }
}
