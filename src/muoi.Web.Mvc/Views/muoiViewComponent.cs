using Abp.AspNetCore.Mvc.ViewComponents;

namespace muoi.Web.Views
{
    public abstract class muoiViewComponent : AbpViewComponent
    {
        protected muoiViewComponent()
        {
            LocalizationSourceName = muoiConsts.LocalizationSourceName;
        }
    }
}
