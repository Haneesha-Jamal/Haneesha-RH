﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainDAL.Model
{
    public partial class Qualification
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public Guid? JobseekerProfileId { get; set; }

        public Guid? JobPostId { get; set; }

        public virtual JobPost? JobPost { get; set; }
        public JobSeekerProfile JobSeekerProfile { get; set; }
    }
}
