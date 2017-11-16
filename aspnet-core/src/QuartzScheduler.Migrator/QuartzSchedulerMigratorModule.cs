using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuartzScheduler.Configuration;
using QuartzScheduler.EntityFrameworkCore;
using QuartzScheduler.Migrator.DependencyInjection;

namespace QuartzScheduler.Migrator
{
    [DependsOn(typeof(QuartzSchedulerEntityFrameworkModule))]
    public class QuartzSchedulerMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public QuartzSchedulerMigratorModule(QuartzSchedulerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(QuartzSchedulerMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                QuartzSchedulerConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuartzSchedulerMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
