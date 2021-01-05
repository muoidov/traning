using System.Threading.Tasks;
using muoi.Configuration.Dto;

namespace muoi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
