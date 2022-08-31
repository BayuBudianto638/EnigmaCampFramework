using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EnigmaCamp.Authorization;

namespace EnigmaCamp
{
    [DependsOn(
        typeof(EnigmaCampCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EnigmaCampApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EnigmaCampAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EnigmaCampApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
