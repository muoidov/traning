using System.Threading.Tasks;
using Abp.Application.Services;
using muoi.Sessions.Dto;

namespace muoi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
