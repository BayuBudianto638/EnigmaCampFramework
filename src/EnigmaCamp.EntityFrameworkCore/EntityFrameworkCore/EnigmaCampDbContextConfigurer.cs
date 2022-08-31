using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EnigmaCamp.EntityFrameworkCore
{
    public static class EnigmaCampDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EnigmaCampDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EnigmaCampDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
