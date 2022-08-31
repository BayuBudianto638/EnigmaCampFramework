using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EnigmaCamp.Configuration;

namespace EnigmaCamp.Web.Startup
{
    [DependsOn(typeof(EnigmaCampWebCoreModule))]
    public class EnigmaCampWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EnigmaCampWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<EnigmaCampNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EnigmaCampWebMvcModule).GetAssembly());
        }
    }
}
