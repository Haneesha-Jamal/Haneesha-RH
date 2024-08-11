using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Interface
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }


        public Person(string firstName,string lastName,string dtOfBirth,string homeAddress,string workAddress) 
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dtOfBirth;
            HomeAddress = homeAddress;
            WorkAddress = workAddress;
        }

        public Person()
        {
        }
    }
}
