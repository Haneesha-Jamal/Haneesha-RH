using AddressBook.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Manager
{
    public class AddressManager
    {
       
        public List<Country> AddAll = new List<Country>();
       
        
        public void AddNewPerson()
        {
            Country country = new Country();

            Console.WriteLine("Enter Id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a fisrtName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter a lastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter a Date of Birth");
            string dtOfBirth = Console.ReadLine();
            Console.WriteLine("Enter a home address");
            string homeAddres = Console.ReadLine();
            Console.WriteLine("Enter a work address");
            string workAddress = Console.ReadLine();


            Console.WriteLine("Enter a Room Number");
            string roomNumber = Console.ReadLine();
            Console.WriteLine("Enter a Building");
            string building = Console.ReadLine();
            Console.WriteLine("Enter a Street");
            string street = Console.ReadLine(); 
            Console.WriteLine("Enter a city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter a phone");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter a email");
            string email = Console.ReadLine();

            AddAll.Add(country);
        }

        public void Display()
        {
            foreach (var person in AddAll)
            {
                Console.WriteLine("Details of Person : " + person.Name);
                Console.WriteLine("Details of Person : " + person.FirstName);
                Console.WriteLine("Details of Person : " + person.LastName);
                Console.WriteLine("Details of Person : " + person.DateOfBirth);
                Console.WriteLine("Details of Person : " + person.HomeAddress);
                Console.WriteLine("Details of Person : " + person.WorkAddress);

            }
            foreach (var address in AddAll)
            {
                Console.WriteLine("Address of Person : " + address);
            }
        }

    }
}




        

