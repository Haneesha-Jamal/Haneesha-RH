using BlazorWorkShop.Models;

namespace BlazorWorkShop.Dto
{
    public class UserProfileDto
    {
        public string? About { get; set; }
        public virtual ICollection<Skills> Skills { get; set; } = new List<Skills>();
        public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();
        public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public string? Designation { get; set; }
        public Guid? companyId { get; set; }
        public string? Image { get; set; }
        public Skills skill { get; set; }
        public Experience experience { get; set; }
        public Qualification qualification { get; set; }
    }
}
