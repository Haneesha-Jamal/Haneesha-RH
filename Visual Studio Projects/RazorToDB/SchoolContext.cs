using Microsoft.EntityFrameworkCore;
using RazorToDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorToDB
{
    public class SchoolContext : DbContext
    {
        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-A4LFVAT;Initial Catalog=SCHOOLDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
