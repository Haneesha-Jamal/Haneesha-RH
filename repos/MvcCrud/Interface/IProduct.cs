using MvcCrud.Models;

namespace MvcCrud.Interface
{
    public interface IProduct
    {
        Products AddProduct(Products prod);
        Products UpdateProduct(Products prod);
        void  DeleteProduct(int id);
        List<Products> GetAllProducts();
        Products GetProductById(int id);
    }
}
