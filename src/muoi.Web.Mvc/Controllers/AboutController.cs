using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using muoi.Controllers;

namespace muoi.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : muoiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
