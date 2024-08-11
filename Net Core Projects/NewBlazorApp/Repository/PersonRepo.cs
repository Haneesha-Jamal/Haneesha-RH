using Microsoft.EntityFrameworkCore;
using NewBlazorApp.DAL;
using NewBlazorApp.Interface;
using NewBlazorApp.Model;

namespace NewBlazorApp.Repository
{
    public class PersonRepo : IPersonRepo
    {
        private readonly NewDbContext _dbContext;
        public PersonRepo(NewDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Person>> GetAllPersonsAsync()
        {
           return await _dbContext.persons.ToListAsync();   
        }
        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await _dbContext.persons.FindAsync(id);
        }
        public async Task AddPersonAsync(Person person)
        {
            _dbContext.persons.Add(person);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdatePersonAsync(Person person)
        {
            _dbContext.persons.Update(person);
            await _dbContext.SaveChangesAsync();

        }
        public async Task DeletePersonAsync(int id)
        {
            var person = await _dbContext.persons.FindAsync(id);
            if (person != null)
            {
                _dbContext.persons.Remove(person);
                await _dbContext.SaveChangesAsync();
            }
        }


    }
}
