﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using BlazorWorkShop.Enums;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkShop.Models
{
    //namespace BlazorWorkShop.Models;
    //[Index(nameof(Email), IsUnique = true)]
    public partial class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string? Gender { get; set; }

        public string? Location { get; set; }

        public string? Phone { get; set; }

        public List<string> Skills { get; set; }
        public string password { get; set; }

        public Roles? Role { get; set; }

        public string? About { get; set; }

        public string? Designation { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid? CompanyId { get; set; } = null;

        public string? Status { get; set; }

        public string? Image { get; set; }

        public DateTime? CreatedDate { get; set; }
        public virtual Company? Company { get; set; }

        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
        public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();

        public virtual ICollection<Interview> InterviewCreatedByNavigations { get; set; } = new List<Interview>();

        public virtual ICollection<Interview> InterviewJobseekers { get; set; } = new List<Interview>();

        public virtual ICollection<Jobs> Jobs { get; set; } = new List<Jobs>();

        public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();

        public virtual ICollection<Skills> Skill { get; set; } = new List<Skills>();
    }
}




