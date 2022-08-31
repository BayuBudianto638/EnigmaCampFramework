using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EnigmaCamp.Controllers
{
    public abstract class EnigmaCampControllerBase: AbpController
    {
        protected EnigmaCampControllerBase()
        {
            LocalizationSourceName = EnigmaCampConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
