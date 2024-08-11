using MVCcrud1.Dal;
using MVCcrud1.Interface;
using MVCcrud1.Models;

namespace MVCcrud1.Service
{
    public class Serviceee : IStoreService
    {
        public StoreDbContext Context = new StoreDbContext();
        public IStoreRepo _store;
        public Serviceee(StoreDbContext dbcontext,IStoreRepo store1) 
        { 
            Context = dbcontext;
            _store = store1;
        }
        public Store Add(Store store)
        {
            _store.Add(store);
            return store;
        }
    }
}
