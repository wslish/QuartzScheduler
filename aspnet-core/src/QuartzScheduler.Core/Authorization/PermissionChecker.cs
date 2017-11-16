using Abp.Authorization;
using QuartzScheduler.Authorization.Roles;
using QuartzScheduler.Authorization.Users;

namespace QuartzScheduler.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
