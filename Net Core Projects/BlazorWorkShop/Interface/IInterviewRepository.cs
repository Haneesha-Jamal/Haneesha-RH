using BlazorWorkShop.Models;

namespace BlazorWorkShop.Interface
{
    public interface IInterviewRepository
    {
        Interview shduleInterview(Interview interview);
        List<Interview> sheduledInterviewList(Guid cmpid);
        void removeInterview(Guid id);
    }
}
