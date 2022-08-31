using Abp.AspNetCore.Mvc.ViewComponents;

namespace EnigmaCamp.Web.Views
{
    public abstract class EnigmaCampViewComponent : AbpViewComponent
    {
        protected EnigmaCampViewComponent()
        {
            LocalizationSourceName = EnigmaCampConsts.LocalizationSourceName;
        }
    }
}
