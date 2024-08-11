using DomainDAL.Services.Authuser.Interfaces;
using System.Security.Claims;


namespace DomainDAL.Services.Authuser
{
    public class AuthUserService:IAuthUserService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IAuthUserRepository _userRepository;

		public AuthUserService(IHttpContextAccessor httpContextAccessor,IAuthUserRepository userRepository)
		{
			_httpContextAccessor = httpContextAccessor;
			_userRepository = userRepository;
		}

		public string GetUserId()
		{
			var result = string.Empty;
			if (_httpContextAccessor.HttpContext != null)
			{
				result = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value.ToString();
			}
			return result;
		}
	
	}
}
