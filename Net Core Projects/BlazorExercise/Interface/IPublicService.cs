using BlazorExercise.Models;

namespace BlazorExercise.Interface
{
    public interface IPublicService
    {
        public User LoginJobSeeker(string email, string password);
        public User Register(User NewUser);
    }
}
