using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace EnigmaCamp.Web.Views
{
    public abstract class EnigmaCampRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected EnigmaCampRazorPage()
        {
            LocalizationSourceName = EnigmaCampConsts.LocalizationSourceName;
        }
    }
}
