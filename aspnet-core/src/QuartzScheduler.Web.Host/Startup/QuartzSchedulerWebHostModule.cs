using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuartzScheduler.Configuration;

namespace QuartzScheduler.Web.Host.Startup
{
    [DependsOn(
       typeof(QuartzSchedulerWebCoreModule))]
    public class QuartzSchedulerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public QuartzSchedulerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuartzSchedulerWebHostModule).GetAssembly());
        }
    }
}
