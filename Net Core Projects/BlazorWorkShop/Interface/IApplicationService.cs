using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IApplicationService
    {
        public List<Application> GetAll(Guid userId);
        public void AddApplication(Guid userId, Guid jobId);
        public List<Application> GetAllByCompany(Guid companyId);

    }
}




