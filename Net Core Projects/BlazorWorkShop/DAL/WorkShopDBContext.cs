using BlazorWorkShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkShop.DAL
{
    public class WorkShopDBContext : DbContext
    {
        public WorkShopDBContext() { }  

        public WorkShopDBContext(DbContextOptions<WorkShopDBContext> options) : base(options) { }

        public virtual DbSet<Application> Applications { get; set; }

        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Experience> Experiences { get; set; }

        public virtual DbSet<Interview> Interviews { get; set; }

        public virtual DbSet<Jobs> Jobs { get; set; }

        public virtual DbSet<Qualification> Qualifications { get; set; }

        public virtual DbSet<Skills> Skills { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}