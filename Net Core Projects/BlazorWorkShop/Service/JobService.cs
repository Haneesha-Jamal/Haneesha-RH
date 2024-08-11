using BlazorWorkShop.Interface;
using BlazorWorkShop.Models;

namespace BlazorWorkShop.Service
{
    public class JobService : IJobService
    {
        IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }



        public void DeleteItemById(Guid id)
        {
            _jobRepository.DeleteById(id);

        }

        public List<Jobs> getByTitle(string title)
        {
            return _jobRepository.getByTitle(title);


        }

        public Jobs getJobById(Guid selectedJobId)
        {
            return _jobRepository.GetJobById(selectedJobId);
        }

        public List<Jobs> GetJobs()
        {
            return _jobRepository.GetJobs();
        }
        
        public List<Jobs> GetJobsByCompany(Guid cmpId)
        {
            return _jobRepository.GetJobsByCompany(cmpId);
        }

        public Jobs PostJob(Jobs job)
        {
            return _jobRepository.PostJob(job);
        }

        public Jobs Update(Jobs job)
        {
            var updatedjob = _jobRepository.Update(job);
            return updatedjob;
        }
    }
}
