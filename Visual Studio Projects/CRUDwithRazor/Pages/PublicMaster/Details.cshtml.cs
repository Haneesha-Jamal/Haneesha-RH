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
    public class DetailsModel : PageModel
    {
        private readonly CRUDwithRazor.Dal.AppDbContext _context;

        public DetailsModel(CRUDwithRazor.Dal.AppDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.p.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}
