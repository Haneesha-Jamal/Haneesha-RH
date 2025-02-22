﻿using APIWorkshop.Controllers;
using DomainDAL.Services.Admin.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DomainDAL.Services.Admin;
using DomainDAL.Services.Login.Interfaces;
using APIWorkshop.API.Admin.RequestObjects;
using DomainDAL.Model;
using DomainDAL.Services.Admin.Dto;

namespace APIWorkshop.API.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : BaseApiController<AdminController>
    {

        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;
        private readonly ILoginRequestService _loginRequestService;
        IAdminRepository _adminRepository;
        private IMapper mapper;


        public AdminController(IMapper mapper, IAdminService adminService, IAdminRepository adminRepostory, ILoginRequestService loginRequestService)
        {
            _mapper = mapper;
            _adminService = adminService;
            _adminRepository = adminRepostory;
            _loginRequestService = loginRequestService;
        }

        [HttpPost]
        [Route("Admin/login")]
        public async Task<ActionResult> Login(AdminLoginRequest logdata)
        {
            //var user = _mapper.Map<User>(userDto);
            var user = _loginRequestService.Adminlogin(logdata.Email, logdata.Password);

            if (user == null)
            {
                return BadRequest("Login Failed");
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("admin/GetJobSeekers")]
        public async Task<IActionResult> GetJobSeekers()
        {

            try
            {
                var jobSeekers = await _adminService.GetJobSeekers();
                return Ok(_mapper.Map<List<JobSeekerDto>>(jobSeekers));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpPost("skillAdd")]
        public async Task<IActionResult> AddSkill(SkillRequest skill)
        {
            // Map the request to DTO

            var Skill = _mapper.Map<PostedSkillDto>(skill);

            // Call the service
            var result = await _adminService.AddSkillAsync(Skill);

            if (result)
            {
                return Ok("Skill added successfully");
            }
            else
            {
                return BadRequest("Skill already exists");
            }
        }

        [HttpDelete("skillRemove/{skillId}")]
        public async Task<IActionResult> RemoveSkill(Guid skillId)
        {
            // Call the service
            var result = await _adminService.RemoveSkillAsync(skillId);

            if (result)
            {
                return Ok("Skill deleted successfully");
            }
            else
            {
                return NotFound("Skill not found or failed to delete");
            }
        }

        [HttpGet]
        [Route("admin/GetCompanies")]
        public async Task<IActionResult> GetCompanies()
        {

            try
            {
                var jobProviders = await _adminService.GetCompanies();
                return Ok(_mapper.Map<List<JobProviderDto>>(jobProviders));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        //New-Code

        [HttpGet]
        [Route("admin/SearchCompanies")]
        public async Task<IActionResult> SearchCompanies(string name)
        {

            try
            {

                var companies = await _adminService.SearchCompanies(name);
                return Ok(_mapper.Map<List<JobProviderDto>>(companies));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        //New-Code Ends


        [HttpGet]
        [Route("admin/jobsbyName")]
        public async Task<IActionResult> getalljobs(string Title)
        {

            try
            {
                var jobs = await _adminService.GetJobs(Title);
                return Ok(_mapper.Map<List<JobListDto>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("alljobs")]
        public async Task<IActionResult> alljobs()
        {

            try
            {
                var jobs = await _adminService.GetJobs();
                return Ok(_mapper.Map<List<JobListDto>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }




        [HttpDelete]
        [Route("admin/RemoveCompanyUsers/{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _adminService.DeleteById(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }



        [HttpGet]
        [Route("admin/GetJobProviderCount")]
        public IActionResult GetJobProviderCount()
        {
            try
            {
                var count = _adminService.GetJobProviderCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/GetJobCount")]
        public IActionResult GetJobCount()
        {
            try
            {
                var count = _adminService.GetJobCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }






        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation(LocationRequest location)
        {
            var Location = _mapper.Map<Location>(location);
            var result = await _adminService.AddLocation(Location);

            return Ok(result);
        }



        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {

            try
            {
                var locations = await _adminService.GetLocations();
                return Ok(_mapper.Map<List<LocationDto>>(locations));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpDelete]
        [Route("RemoveLocations/{id}")]
        public IActionResult RemoveLocation(Guid id)
        {
            try
            {
                _adminService.DeleteByLocationId(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }





    }


}
}
