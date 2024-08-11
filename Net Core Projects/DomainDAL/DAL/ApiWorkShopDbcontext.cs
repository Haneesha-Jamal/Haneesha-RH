using DomainDAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDAL.DAL
{
    public class ApiWorkShopDbcontext : DbContext
    {
        public ApiWorkShopDbcontext() { }

        public ApiWorkShopDbcontext(DbContextOptions options) : base(options)
        {
        }


        public virtual DbSet<AuthUser> AuthUsers { get; set; }
        public virtual DbSet<SignUpRequest> SignUpRequests { get; set; }

        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }

        public virtual DbSet<Industry> Industries { get; set; }

        public virtual DbSet<JobCategory> JobCategories { get; set; }

        public virtual DbSet<JobPost> JobPosts { get; set; }

        public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }

        public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; }

        public virtual DbSet<JobSeeker> JobSeekers { get; set; }

        public virtual DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }

        public virtual DbSet<Location> Locations { get; set; }


        public virtual DbSet<JobApplication> JobApplications { get; set; }

        public virtual DbSet<Qualification> Qualifications { get; set; }

        public virtual DbSet<Resume> Resumes { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SavedJob> SavedJobs { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }

        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageGroup> MessageGroups { get; set; }
        public virtual DbSet<GroupMember> GroupMember { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobSeekerProfile>()
                .HasMany(jsp => jsp.JobSeekerProfileSkills)
                .WithOne(jps => jps.JobSeekerProfile)
                .HasForeignKey(jps => jps.JobSeekerProfileId);

            modelBuilder.Entity<JobSeekerProfileSkill>()
                .HasOne(jps => jps.Skill)
                .WithMany() // Assuming Skill does not have a collection of JobSeekerProfileSkills
                .HasForeignKey(jps => jps.SkillId);
            modelBuilder.Entity<JobPost>()
          .HasOne(jp => jp.Company)
          .WithMany()
          .HasForeignKey(jp => jp.CompanyId)
          .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
