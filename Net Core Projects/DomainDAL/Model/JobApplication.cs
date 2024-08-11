using APIWorkshop.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainDAL.Model
{
    public partial class JobApplication
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [ForeignKey(nameof(JobPost))]
        public Guid JobPost_id { get; set; }
        [ForeignKey(nameof(Seeker))]
        public Guid Applicant { get; set; }

        [ForeignKey(nameof(Resume))]
        public Guid Resume_id { get; set; }

        public string CoverLetter { get; set; }

        public DateTime Datesubmitted { get; set; }
        public Status status { get; set; }

        public virtual Resume Resume { get; set; }
        public virtual JobSeeker Seeker { get; set; }
        public virtual JobPost JobPost { get; set; }

    }
}
