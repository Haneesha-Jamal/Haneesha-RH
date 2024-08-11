using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainDAL.Model
{
    public partial class JobSeekerProfileSkill
    {
        [Key]
        public Guid JobSeekerProfileId { get; set; }

        [ForeignKey(nameof(JobSeekerProfileId))]
        public virtual JobSeekerProfile JobSeekerProfile { get; set; }

        public Guid SkillId { get; set; }
        public virtual Skill Skill { get; set; }
    }

}
