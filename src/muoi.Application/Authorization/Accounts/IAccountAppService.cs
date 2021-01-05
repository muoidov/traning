using System.Threading.Tasks;
using Abp.Application.Services;
using muoi.Authorization.Accounts.Dto;

namespace muoi.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
