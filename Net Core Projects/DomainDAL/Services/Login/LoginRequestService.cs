using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DomainDAL.Services.Authuser;
using DomainDAL.Services.Authuser.Interfaces;
using DomainDAL.Services.Login.DTOs;
using DomainDAL.Services.Login.Interfaces;


namespace DomainDAL.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        ILoginRequestRepository   loginRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        public LoginRequestService(ILoginRequestRepository _jobSeekerRepository, IMapper _mapper, IAuthUserRepository _authUserRepository)
        {
            loginRepository = _jobSeekerRepository;
            mapper = _mapper;
            
            authUserRepository = _authUserRepository;
        }

     

        public AdminLoginDTO Adminlogin(string email, string password)
        {
            var user = loginRepository.GetUserByEmail(email);
            if (user == null)
            {
                return null;
            }
            else
            {
                if ((password == user.Password))
                {
                    var userReturn = mapper.Map<AdminLoginDTO>(user);
                    userReturn.Token = authUserRepository.CreateToken(user);
                    return userReturn;
                }
                return null;
            }

        }
    }
       
    }

