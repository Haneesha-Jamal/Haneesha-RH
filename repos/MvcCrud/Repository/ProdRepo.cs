using MvcCrud.Interface;
using MvcCrud.Models;

namespace MvcCrud.Repository
{
    public class ProdRepo : IProduct
    {
        ProDBContext dbContext = new ProDBContext();
        public ProdRepo(ProDBContext Prodbcontext)
        {
            dbContext= Prodbcontext;
        }

        public Products AddProduct(Products prod)
        {
            dbContext.products.Add(prod);
            dbContext.SaveChanges();    
            return prod;
        }
        public Products UpdateProduct(Products prod)
        {
            dbContext.products.Update(prod);
            dbContext.SaveChanges();
            return prod;
        }
        public void DeleteProduct(int id)
        {
            var remove = dbContext.products.Find(id);
            if(remove != null)
            {
                dbContext.products.Remove(remove);
                dbContext.SaveChanges();
            }
            else
            {
                return;
            }
        }
          
        public List<Products> GetAllProducts()
        {
            return dbContext.products.ToList();
        }
        public Products GetProductById(int id)
        {
            var produc = dbContext.products.Where(e => e.Id == id).FirstOrDefault();
            return produc;
        }
    }
}
