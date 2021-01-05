using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace muoi.EntityFrameworkCore
{
    public static class muoiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<muoiDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<muoiDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }

    }
}
