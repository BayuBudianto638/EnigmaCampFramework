using System.Threading.Tasks;
using EnigmaCamp.Configuration.Dto;

namespace EnigmaCamp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
