

using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IApplicationRepository
    {
        public List<Application> GetAll(Guid userId);
        public void AddApplication(Application application);
        List<Application> GetAllByCompany(Guid companyId);
        Application GetApplication(Guid appid);
    }
}
