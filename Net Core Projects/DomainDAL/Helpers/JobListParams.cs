using DomainDAL.Helpers;

namespace DomainDAL.Helpers
{
	public class JobListParams: PaginationParams
	{

		public string JobTitle { get; set; } = null!;

	}
}
