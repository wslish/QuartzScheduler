using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using QuartzScheduler.Configuration;
using QuartzScheduler.Web;

namespace QuartzScheduler.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class QuartzSchedulerDbContextFactory : IDesignTimeDbContextFactory<QuartzSchedulerDbContext>
    {
        public QuartzSchedulerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<QuartzSchedulerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            QuartzSchedulerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(QuartzSchedulerConsts.ConnectionStringName));

            return new QuartzSchedulerDbContext(builder.Options);
        }
    }
}
