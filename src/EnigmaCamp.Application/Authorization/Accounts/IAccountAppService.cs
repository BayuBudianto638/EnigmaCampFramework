using System.Threading.Tasks;
using Abp.Application.Services;
using EnigmaCamp.Authorization.Accounts.Dto;

namespace EnigmaCamp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
