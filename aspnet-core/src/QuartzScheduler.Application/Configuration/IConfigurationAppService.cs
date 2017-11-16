using System.Threading.Tasks;
using QuartzScheduler.Configuration.Dto;

namespace QuartzScheduler.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
