﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDAL.Model;

namespace DomainDAL.Services.Login.Interfaces
{
    public interface ILoginRequestRepository
    {

        AuthUser GetUserByEmail(string email);
	
	}
}
