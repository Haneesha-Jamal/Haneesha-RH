using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDAL.Services.Login.DTOs;

namespace DomainDAL.Services.Login.Interfaces
{
    public interface ILoginRequestService
    {

    

        AdminLoginDTO Adminlogin(string email, string password);
    }
}
