using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QuartzScheduler.EntityFrameworkCore
{
    public static class QuartzSchedulerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QuartzSchedulerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QuartzSchedulerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
