using System.Threading.Tasks;
using Abp.Application.Services;
using QuartzScheduler.Sessions.Dto;

namespace QuartzScheduler.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
