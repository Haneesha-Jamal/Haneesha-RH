using Microsoft.EntityFrameworkCore;
using MvcCrud.Models;
using MvcCrud.Dto;

namespace MvcCrud.DAL
{
    public class PersonDBContext :DbContext
    {
        public PersonDBContext() { }

        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options) { }
       
        public virtual DbSet<Person> people { get; set; }
        public DbSet<MvcCrud.Dto.PersonDto> PersonDto { get; set; } = default!;
    }
}
