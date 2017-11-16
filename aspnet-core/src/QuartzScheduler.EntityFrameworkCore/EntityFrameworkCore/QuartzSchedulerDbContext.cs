using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QuartzScheduler.Authorization.Roles;
using QuartzScheduler.Authorization.Users;
using QuartzScheduler.MultiTenancy;

namespace QuartzScheduler.EntityFrameworkCore
{
    public class QuartzSchedulerDbContext : AbpZeroDbContext<Tenant, Role, User, QuartzSchedulerDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public QuartzSchedulerDbContext(DbContextOptions<QuartzSchedulerDbContext> options)
            : base(options)
        {
        }
    }
}
