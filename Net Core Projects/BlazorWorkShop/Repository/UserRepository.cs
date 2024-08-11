using BlazorWorkShop.DAL;
using BlazorWorkShop.Enums;
using BlazorWorkShop.Exceptions;
using BlazorWorkShop.Interface;
using BlazorWorkShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkShop.Repository
{
    public class UserRepository : IUserRepository
    {
        WorkShopDBContext workContext = new WorkShopDBContext();

        private static User loggedUser = new User();
        public UserRepository(WorkShopDBContext context)
        {
           workContext = context;
        }

        public User Login(string email, string password)
        {
            loggedUser = workContext.Users.Where(e => e.Email == email && e.password == password).FirstOrDefault();
            return loggedUser;
        }

        public User register(User user)
        {
            user.Id = Guid.NewGuid();
            user.Role = Roles.JobSeeker; ;
            var userallready = workContext.Users.FirstOrDefault(e => e.Email == user.Email);

            if (userallready == null)
            {
                workContext.Users.Add(user);
                workContext.SaveChanges();
                return user;
            }
            else
            {
                throw new UserAlreadyExistException(user.Email);
            }
        }

        public List<User> jobseekerListing()
        {
            var memberList =workContext.Users.Where(e => e.Role == Roles.JobSeeker).ToList();
            return memberList;
        }

        public User getuser()
        {
            return loggedUser;
        }
        public void Logout()
        {
            loggedUser = null;
        }
        public List<User> GetByFilter(string search, Roles role)
        {
            var memberList = workContext.Users.Where(e => (e.Role == role) && e.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            return memberList;
        }

        public User getById(Guid userId)
        {
            User user = workContext.Users.Where(e => e.Id == userId).Include(x => x.Skills)
                .Include(x => x.Experiences)
                .Include(x => x.Qualifications).IgnoreAutoIncludes().FirstOrDefault();
            return user;
        }

        void IUserRepository.AddExperience(Experience experience, Guid guid)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.AddQualification(Qualification qualification, Guid guid)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.AddSkill(Skills skills, Guid guid)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.memberListing(Guid? companyId)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.memberRegister(User user)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.jobProviderListing()
        {
            throw new NotImplementedException();
        }

        User IUserRepository.Update(User user)
        {
            throw new NotImplementedException();
        }


    }
}


