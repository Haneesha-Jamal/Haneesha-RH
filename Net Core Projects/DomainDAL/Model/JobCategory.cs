using System.ComponentModel.DataAnnotations;

namespace DomainDAL.Model
{
    public partial class JobCategory
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
