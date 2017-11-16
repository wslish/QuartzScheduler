using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuartzScheduler.Authorization;

namespace QuartzScheduler
{
    [DependsOn(
        typeof(QuartzSchedulerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QuartzSchedulerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QuartzSchedulerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QuartzSchedulerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
