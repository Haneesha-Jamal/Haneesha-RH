using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DomainDAL.Model
{
    public partial class GroupMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ToUserId { get; set; }
        public string Email { get; set; }
        [ForeignKey(nameof(MessageGroup))]
        public Guid? MessageGroupId { get; set; }
        [JsonIgnore]
        public virtual MessageGroup? MessageGroup { get; set; }
    }
}
