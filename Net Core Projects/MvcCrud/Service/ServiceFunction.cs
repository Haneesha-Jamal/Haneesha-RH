using MvcCrud.DAL;
using MvcCrud.Interface;
using MvcCrud.Models;

namespace MvcCrud.Service
{
    public class ServiceFunction : IService
    {
        PersonDBContext persondb = new PersonDBContext();
        IRepo _repo;
        public ServiceFunction(PersonDBContext personDB , IRepo repo) 
        {
           persondb = personDB;
           _repo = repo;
        }

        public Person AddPerson(Person person)
        {
            _repo.AddPerson(person);
            return person;
        }
    }
}
