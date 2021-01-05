using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using muoi.Configuration;
using muoi.Web;

namespace muoi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class muoiDbContextFactory : IDesignTimeDbContextFactory<muoiDbContext>
    {
        public muoiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<muoiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            muoiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(muoiConsts.ConnectionStringName));

            return new muoiDbContext(builder.Options);
        }
    }
}
