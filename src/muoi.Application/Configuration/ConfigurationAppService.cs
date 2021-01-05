using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using muoi.Configuration.Dto;

namespace muoi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : muoiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
