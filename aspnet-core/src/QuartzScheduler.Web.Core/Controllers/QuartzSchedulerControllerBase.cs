using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QuartzScheduler.Controllers
{
    public abstract class QuartzSchedulerControllerBase: AbpController
    {
        protected QuartzSchedulerControllerBase()
        {
            LocalizationSourceName = QuartzSchedulerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
