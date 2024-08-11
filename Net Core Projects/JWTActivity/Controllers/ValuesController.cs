using JWTActivity.DAL;
using JWTActivity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTActivity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public UserDbContext _DbContext;
        public ValuesController(UserDbContext userDb) 
        { 
            _DbContext = userDb;
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
           _DbContext.userss.Add(user);
            _DbContext.SaveChanges();
            return Ok(user);
        }

        [HttpPost("login")]
        public IActionResult login(string email, string password)
        {
            var user = _DbContext.userss.Where(e => e.Email == email && e.Password == password).FirstOrDefault();
            if (user == null)

            {
                return BadRequest("Invalid credentrials");
            }
            else
            {
                return Ok();
            }


        }

    }
}
