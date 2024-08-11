using MvcCrud.DAL;
using MvcCrud.Interface;
using MvcCrud.Models;

namespace MvcCrud.Repository
{
    public class Repo : IRepo
    {
        PersonDBContext persondb = new PersonDBContext();   

        public Repo(PersonDBContext personDB) 
        {
            persondb = personDB;
        }

        public Person AddPerson(Person person)
        {
            persondb.Add(person);
            persondb.SaveChanges();
            return person;
        }
    }
}
