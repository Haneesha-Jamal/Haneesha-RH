using MVCcrud1.Dal;
using MVCcrud1.Interface;
using MVCcrud1.Models;

namespace MVCcrud1.Repository
{
    public class Repo : IStoreRepo
    {
        public StoreDbContext Context = new StoreDbContext();
        public Repo(StoreDbContext storeDbContext) 
        { 
            Context = storeDbContext;
        }

        public Store Add(Store store)
        {
            Context.Add(store);
            Context.SaveChanges();
            return store;
        }

    }
}
