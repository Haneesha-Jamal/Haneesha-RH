using APIWorkshop.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainDAL.Model
{
    public class SignUpRequest
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Status Status { get; set; }
    }
}
