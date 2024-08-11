using BlazorWorkShop.Interface;
using BlazorWorkShop.Models;

namespace BlazorWorkShop.Service
{
    public class InterviewService : IInterviewService
    {
        public IInterviewRepository interviewRepository;

        public InterviewService(IInterviewRepository interviewRepository)
        {
            this.interviewRepository = interviewRepository;
        }

        public void removeInterview(Guid id)
        {
            interviewRepository.removeInterview(id);
        }

        public List<Interview> sheduledInterviewList(Guid cmpid)
        {
            return interviewRepository.sheduledInterviewList(cmpid);
        }

        public Interview sheduleinterview(Interview interview)
        {
            return interviewRepository.shduleInterview(interview);
        }

    }
}
