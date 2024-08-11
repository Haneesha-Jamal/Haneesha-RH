using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainDAL.Model
{
    public partial class JobPost
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string JobTitle { get; set; } = null!;
        public string JobSummary { get; set; } = null!;
        public Guid LocationId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid IndustryId { get; set; }
        public Guid PostedBy { get; set; }
        public DateTime PostedDate { get; set; }
        public virtual Location Location { get; set; } = null!;
        public virtual Industry Industry { get; set; } = null!;
        public virtual JobProviderCompany Company { get; set; } = null!;
        public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; } = new List<JobResponsibility>();
        public virtual CompanyUser PostedByNavigation { get; set; } = null!;
        public virtual JobCategory JobCategory { get; set; } = null!;
    }

}
