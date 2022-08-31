using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EnigmaCamp.EntityFrameworkCore;
using EnigmaCamp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace EnigmaCamp.Web.Tests
{
    [DependsOn(
        typeof(EnigmaCampWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EnigmaCampWebTestModule : AbpModule
    {
        public EnigmaCampWebTestModule(EnigmaCampEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EnigmaCampWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EnigmaCampWebMvcModule).Assembly);
        }
    }
}