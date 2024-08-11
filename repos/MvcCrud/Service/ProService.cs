using MvcCrud.Interface;
using MvcCrud.Models;

namespace MvcCrud.Service
{
    public class ProService : IProduct
    {
        public ProDBContext ProDB = new ProDBContext();
        public IProduct _product;

        public ProService(IProduct product,ProDBContext proDBContext)
        {
            _product = product;
            ProDB = proDBContext;
        }

        public Products AddProduct(Products prod)
        {
           return _product.AddProduct(prod);
        }
        public Products UpdateProduct(Products prod)
        {
            var updPro = ProDB.products.Find(prod.Id);
            if(updPro != null)
            {
                updPro.Id = prod.Id;
                updPro.Name = prod.Name;
                updPro.Description = prod.Description;
                updPro.Amount = prod.Amount;
                updPro.Qty = prod.Qty;
            }
            return prod;
        }
        public void DeleteProduct(int id)
        {
            _product.DeleteProduct(id);
        }
        public List<Products> GetAllProducts()
        {
           return _product.GetAllProducts();
        }
         public  Products GetProductById(int id)
        {
            return _product.GetProductById(id);
        }

    }
}
