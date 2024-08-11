using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageTutor.Model;

namespace RazorPageTutor.Pages
{
    public class IndexModel : PageModel
    {
        public List <Product> Products { get; set; }
        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Id = 1,Name = "Books",Price = 3000 },
                new Product { Id = 2,Name = "Uniform", Price = 1000},
                new Product { Id = 3,Name = "Bag", Price = 500}
            };
        }

    }
}
