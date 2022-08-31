using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EnigmaCamp.Configuration.Dto;

namespace EnigmaCamp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EnigmaCampAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
