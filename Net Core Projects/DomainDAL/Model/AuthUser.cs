namespace DomainDAL.Model
{
    public partial class AuthUser : SystemUser
    {
        public string? Password { get; set; }
        public string? ConnectionId { get; set; }
        public bool? OnlineStatus { get; set; } = false;
    }
}
