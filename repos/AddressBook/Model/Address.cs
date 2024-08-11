using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Interface
{
    public class Address : Person
    {
       
        public string RoomNumber { get; set; }
        public string Building{ get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
            
        public Address(string roomNumber,string building,string street,string city,string phone,string email) 
        {
            RoomNumber = roomNumber;
            Building = building;
            Street = street;
            City = city;
            Phone = phone;
            Email = email;

        }

        public Address()
        {
        }
    }

    
}
