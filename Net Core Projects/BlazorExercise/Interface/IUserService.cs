using BlazorExercise.Models;

namespace BlazorExercise.Interface
{
    public interface IUserService
    {
        User login(string email, string password);

        User register(User user);

        void Logout();

        List<User> memberListing(Guid? companyId);
    }
}
