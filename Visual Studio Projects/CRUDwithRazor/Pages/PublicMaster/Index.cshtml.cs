using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDwithRazor.Dal;
using CRUDwithRazor.Models;

namespace CRUDwithRazor.Pages.PublicMaster
{
    public class IndexModel : PageModel
    {
        private readonly CRUDwithRazor.Dal.AppDbContext _context;

        public IndexModel(CRUDwithRazor.Dal.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.p.ToListAsync();
        }
    }
}
