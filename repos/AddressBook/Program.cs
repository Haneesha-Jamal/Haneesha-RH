using AddressBook.Manager;

namespace AddressBook
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            AddressManager manager = new AddressManager();
            manager.AddNewPerson();
            manager.Display();
        }
    }

}