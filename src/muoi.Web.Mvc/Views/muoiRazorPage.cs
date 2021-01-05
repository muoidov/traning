using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace muoi.Web.Views
{
    public abstract class muoiRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected muoiRazorPage()
        {
            LocalizationSourceName = muoiConsts.LocalizationSourceName;
        }
    }
}
