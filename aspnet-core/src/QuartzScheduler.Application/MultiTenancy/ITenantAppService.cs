using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QuartzScheduler.MultiTenancy.Dto;

namespace QuartzScheduler.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
