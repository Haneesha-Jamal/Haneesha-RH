using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IJobService
    {
        public Jobs PostJob(Jobs job);
        public List<Jobs> GetJobs();
        public List<Jobs> GetJobsByCompany(Guid companyId);
        public Jobs getJobById(Guid selectedJobId);
        void DeleteItemById(Guid id);
        Jobs Update(Jobs job);

        List<Jobs> getByTitle(string title);
    }
}
