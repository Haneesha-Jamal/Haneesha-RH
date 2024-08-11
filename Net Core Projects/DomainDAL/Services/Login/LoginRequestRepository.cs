using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDAL.DAL;
using DomainDAL.Model;
using DomainDAL.Services.Login.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DomainDAL.Services.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        protected readonly ApiWorkShopDbcontext _context;
        public LoginRequestRepository(ApiWorkShopDbcontext dbContext)
        {
            _context = dbContext;
        }

        public AuthUser GetUserByEmail(string email)
        {
            var user= _context.AuthUsers.FirstOrDefault(e => e.Email == email);
            return user;
        }
	

		public AuthUser GetUserByEmailpassword(string email, string password)
		{
			var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
			return user;
		}
}
    }
