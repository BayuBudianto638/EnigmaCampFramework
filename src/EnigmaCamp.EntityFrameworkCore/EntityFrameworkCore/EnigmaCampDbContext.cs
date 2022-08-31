using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EnigmaCamp.Authorization.Roles;
using EnigmaCamp.Authorization.Users;
using EnigmaCamp.MultiTenancy;

namespace EnigmaCamp.EntityFrameworkCore
{
    public class EnigmaCampDbContext : AbpZeroDbContext<Tenant, Role, User, EnigmaCampDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EnigmaCampDbContext(DbContextOptions<EnigmaCampDbContext> options)
            : base(options)
        {
        }
    }
}
