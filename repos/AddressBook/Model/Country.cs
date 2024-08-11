using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Interface
{
    public class Country:City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country(int id, string name)
        {
            Id = id; ;
            Name = name;
        }

        public Country()
        {
        }
    }
}
