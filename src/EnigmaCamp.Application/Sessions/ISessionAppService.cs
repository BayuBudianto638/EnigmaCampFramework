using System.Threading.Tasks;
using Abp.Application.Services;
using EnigmaCamp.Sessions.Dto;

namespace EnigmaCamp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
