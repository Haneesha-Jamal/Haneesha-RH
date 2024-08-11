using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IJobRepository
    {
        Jobs PostJob(Jobs job);
        Jobs Update(Jobs job);
        List<Jobs> GetJobs();
        Jobs GetJobById(Guid selectedJobId);
        List<Jobs> GetJobsByIds(List<Guid> appliedJobsIds);


        void DeleteById(Guid id);
        List<Jobs> getByTitle(string title);
        List<Jobs> GetJobsByCompany(Guid cmpId);
    }
}
