using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Interface
{
    public class City:Address
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public City(int id,string name) 
        {
            Id=id; ;
            Name=name;
        }

        public City()
        {
        }
    }
}
