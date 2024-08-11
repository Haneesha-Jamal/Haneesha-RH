﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainDAL.Model
{
    public partial class MessageGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int newCount { get; set; }
        public bool IsNewMessages { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string? Members { get; set; }
        public virtual IList<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();
        public virtual IList<Message> Messages { get; set; } = new List<Message>();
    }
}
