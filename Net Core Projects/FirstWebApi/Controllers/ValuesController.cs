using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly BrandDbContext db;
        public ValuesController(BrandDbContext brandDbContext) 
        { 
            db = brandDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrand()
        {
            if (db.brands == null)
            {
                return NotFound();
            }
            return await db.brands.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrands(int id)
        {
            if(db.brands == null)
            {
                return NotFound();
            }
            var bnd = await db.brands.FindAsync(id);
            if(bnd == null)
            {
                return NotFound();
            }
            return bnd;
        }

        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            db.brands.Add(brand);
            await db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBrand), new {id = brand.Id},brand);
        }

    }
}
