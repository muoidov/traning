using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace muoi.Controllers
{
    public abstract class muoiControllerBase: AbpController
    {
        protected muoiControllerBase()
        {
            LocalizationSourceName = muoiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
