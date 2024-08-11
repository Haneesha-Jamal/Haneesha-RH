using DomainDAL.Model;
using DomainDAL.Services.Admin.Dto;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDAL.Services.Admin.Interface
{
    public interface IAdminService
    {
        public Task<List<DomainDAL.Model.JobSeeker>> GetJobSeekers();

        public Task<List<JobProviderCompany>> GetCompanies();

        public void DeleteById(Guid id);
        public void DeleteByLocationId(Guid id);

        public int GetJobProviderCount();
        public int GetJobCount();

        public Task<List<JobPost>> GetJobs(string JobLitle);

        public Task<List<JobProviderCompany>> SearchCompanies(string name);

        Task<bool> AddSkillAsync(PostedSkillDto skill);

        Task<bool> RemoveSkillAsync(Guid skillId);



        Task<Location> AddLocation(Location location);

        public Task<List<Location>> GetLocations();

        public Task<List<JobPost>> GetJobs();
    }
}
