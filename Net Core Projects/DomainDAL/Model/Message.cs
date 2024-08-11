using APIWorkshop.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DomainDAL.Model
{
    public partial class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        //[ForeignKey(nameof(FromUser))]
        public Guid? FromUserId { get; set; }
        //[ForeignKey(nameof(ToUser))]
        public Guid? ToUserId { get; set; }
        [ForeignKey(nameof(MessageGroup))]
        public Guid? MessageGroupId { get; set; }

        public string? From { get; set; }
        public string? To { get; set; }
        [Required]
        public string? Content { get; set; }
        public DateTime SentDate { get; set; } = DateTime.Now;
        public string? ToGroup { get; set; }
        public MessageStatus Status { get; set; }
        [JsonIgnore]
        public virtual MessageGroup? MessageGroup { get; set; }
    }
}
