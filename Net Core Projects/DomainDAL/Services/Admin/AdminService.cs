using AutoMapper;
using DomainDAL.Model;
using DomainDAL.Services.Admin.Dto;
using DomainDAL.Services.Admin.Interface;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDAL.Services.Admin
{
    public class AdminService : IAdminService
    {
        IAdminRepository _adminRepository;
        IMapper _mapper;

        public AdminService(IAdminRepository adminRepository, IMapper mapper)


        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }
        public async Task<List<DomainDAL.Model.JobSeeker>> GetJobSeekers()
        {
            return await _adminRepository.GetJobSeekers();
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _adminRepository.GetCompanies();
        }




        public async Task<List<Location>> GetLocations()
        {
            return await _adminRepository.GetLocations();
        }



        public async Task<List<JobPost>> GetJobs()
        {
            return await _adminRepository.GetJobs();
        }
        public void DeleteById(Guid id)
        {
            _adminRepository.DeleteById(id);
        }

        public void DeleteByLocationId(Guid id)
        {
            _adminRepository.DeleteByLocationId(id);
        }




        public int GetJobProviderCount()
        {
            return _adminRepository.GetJobProviderCount();
        }

        public int GetJobCount()
        {
            return _adminRepository.GetJobCount();
        }
        public async Task<List<JobPost>> GetJobs(string JobLitle)
        {

            var jobs = await _adminRepository.GetJobs(JobLitle);

            return jobs;


        }


        public Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
            return _adminRepository.SearchCompanies(name);
        }



        public async Task<bool> AddSkillAsync(PostedSkillDto skill)
        {
            var Skill = _mapper.Map<Skill>(skill);
            var result = await _adminRepository.AddAsync(Skill);

            return result;
        }


        public async Task<bool> RemoveSkillAsync(Guid skillId)
        {
            var result = await _adminRepository.RemoveAsync(skillId);

            return result;
        }


        public Task<Location> AddLocation(Location location)
        {
            return _adminRepository.addLocation(location);
        }

    }
}
