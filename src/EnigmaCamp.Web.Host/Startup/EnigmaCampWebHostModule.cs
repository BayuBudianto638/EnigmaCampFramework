using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EnigmaCamp.Configuration;

namespace EnigmaCamp.Web.Host.Startup
{
    [DependsOn(
       typeof(EnigmaCampWebCoreModule))]
    public class EnigmaCampWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EnigmaCampWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EnigmaCampWebHostModule).GetAssembly());
        }
    }
}
