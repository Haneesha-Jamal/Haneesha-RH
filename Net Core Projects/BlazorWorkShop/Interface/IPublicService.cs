using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IPublicService
    {
        public User LoginJobSeeker(string email, string password);
        public User Register(User newJobSeeker);
    }
}
