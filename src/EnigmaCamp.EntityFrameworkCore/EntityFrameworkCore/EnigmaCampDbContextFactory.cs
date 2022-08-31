using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EnigmaCamp.Configuration;
using EnigmaCamp.Web;

namespace EnigmaCamp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EnigmaCampDbContextFactory : IDesignTimeDbContextFactory<EnigmaCampDbContext>
    {
        public EnigmaCampDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EnigmaCampDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EnigmaCampDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EnigmaCampConsts.ConnectionStringName));

            return new EnigmaCampDbContext(builder.Options);
        }
    }
}
