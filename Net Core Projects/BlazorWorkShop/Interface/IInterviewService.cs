using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IInterviewService
    {
        Interview sheduleinterview(Interview interview);
        List<Interview> sheduledInterviewList(Guid cmpid);
        void removeInterview(Guid id);
    }
}
