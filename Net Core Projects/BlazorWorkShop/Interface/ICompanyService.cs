using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface ICompanyService
    {
        User memberRegister(User user);
        public List<User> memberListing(Guid? companyId);
        void memberDeleteById(Guid id);
        Company? Register(Company company);
        Company Update(Company company);
        Company? getCompanyById(Guid value);
    }
}
