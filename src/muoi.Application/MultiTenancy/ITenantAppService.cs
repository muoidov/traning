using Abp.Application.Services;
using muoi.MultiTenancy.Dto;

namespace muoi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

