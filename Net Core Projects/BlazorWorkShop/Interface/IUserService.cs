using BlazorWorkShop.Enums;
using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IUserService
    {
        User login(string email, string password);
        void Addabout(string? about, Guid id);
        void AddExperience(Experience experience, Guid guid);
        void AddQualification(Qualification qualification, Guid guid);
        void AddSkill(Skills skills, Guid guid);
        User getById(Guid userId);
        User getLoggedUser();
        User register(User user);
        public List<User> GetByFilter(string search, Roles role);
        public List<User> jobseekerListing();
        public List<User> jobProviderListing();
        User Update(User user);
        void Logout();
    }
}
