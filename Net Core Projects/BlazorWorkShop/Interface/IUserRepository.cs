using BlazorWorkShop.Enums;
using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IUserRepository
    {
        public void AddExperience(Experience experience, Guid guid);
        public void AddQualification(Qualification qualification, Guid guid);
        public void AddSkill(Skills skills, Guid guid);
        List<User> GetByFilter(string search, Roles role);
        User getById(Guid userId);
        User getuser();
        public List<User> memberListing(Guid? companyId);
        void RemoveById(Guid id);
        User memberRegister(User user);
        public List<User> jobseekerListing();
        List<User> jobProviderListing();
        User Login(string email, string password);
        void Logout();
        User register(User user);
        User Update(User user);
    }
}
