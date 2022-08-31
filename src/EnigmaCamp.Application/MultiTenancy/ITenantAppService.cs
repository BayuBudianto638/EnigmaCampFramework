using Abp.Application.Services;
using EnigmaCamp.MultiTenancy.Dto;

namespace EnigmaCamp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

