using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface ICompanyRepository
    {
        Company? getById(Guid id);
        Company? Register(Company company);
        Company Update(Company company);
    }
}
